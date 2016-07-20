using Foundation;
using System;
using UIKit;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using CoreGraphics;

using Xuni.iOS.Core;
using Xuni.iOS.FlexGrid;

namespace FlexGridSample
{
	public class YouTubeCollectionView: XuniCursorCollectionView<YouTubeDataSample>
	{
		private static async Task<Tuple<string, string[]>> SearchVideos (string q, string orderBy, string pageToken, int maxResults)
		{
			var youtubeUrl = string.Format ("https://www.googleapis.com/youtube/v3/search?part=snippet&type=video&q={0}&order={1}&maxResults={2}{3}&key={4}", Uri.EscapeUriString (q), orderBy, maxResults, string.IsNullOrWhiteSpace (pageToken) ? "" : "&pageToken=" + pageToken, "AIzaSyDFz8V9U0ccKXQ5oSrcRSoHqpaursqOudo");

			var client = new HttpClient ();
			var response = await client.GetAsync (youtubeUrl);
			if (response.IsSuccessStatusCode) {
				var videos = new List<string> ();
				var serializer = new DataContractJsonSerializer (typeof(YouTubeSearchResult));
				YouTubeSearchResult result = null;
				try {
					result = serializer.ReadObject (await response.Content.ReadAsStreamAsync ()) as YouTubeSearchResult;
				} catch (Exception e) {
					Console.WriteLine (e);
				}
				foreach (var item in result.Items) {
					videos.Add (item.Id.VideoId);
				}
				return new Tuple<string, string[]> (result.NextPageToken, videos.ToArray ());
			} else {
				throw new Exception (await response.Content.ReadAsStringAsync ());
			}
		}

		private static async Task<IReadOnlyList<YouTubeVideo>> ListVideos (string[] ids)
		{
			var youtubeUrl = string.Format ("https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&id={0}&key={1}", string.Join (",", ids), "AIzaSyDFz8V9U0ccKXQ5oSrcRSoHqpaursqOudo");
			var client = new HttpClient ();
			var response = await client.GetAsync (youtubeUrl);
			if (response.IsSuccessStatusCode) {
				var serializer = new DataContractJsonSerializer (typeof(YouTubeVideoListResult));
				var result = serializer.ReadObject (await response.Content.ReadAsStreamAsync ()) as YouTubeVideoListResult;
				return result.Items;
			} else {
				throw new Exception (await response.Content.ReadAsStringAsync ());
			}
		}

		public static async Task<Tuple<string, IReadOnlyList<YouTubeVideo>>> LoadVideosAsync (string q, string orderBy, string pageToken, int maxResults)
		{
			var searchResult = await SearchVideos (q, orderBy, pageToken, maxResults);
			var videos = await ListVideos (searchResult.Item2);
			return new Tuple<string, IReadOnlyList<YouTubeVideo>> (searchResult.Item1, videos);
		}

		private string _q;
		private string _orderBy = "relevance";
		private string _pageToken = null;

		public YouTubeCollectionView (string query, string orderBy) : base ()
		{
			_q = query;
			_orderBy = orderBy;
		}

		public override bool HasMoreItems ()
		{
			return true;
		}

		public override IEnumerable<YouTubeDataSample> ItemGetter (int? request)
		{
			List<YouTubeDataSample> dataToAppend = new List<YouTubeDataSample> ();

			Tuple<string, IReadOnlyList<YouTubeVideo>> results = LoadVideosAsync (_q, _orderBy, _pageToken, 10).Result;
			_pageToken = results.Item1;


			foreach (YouTubeVideo yv in results.Item2)
				dataToAppend.Add (new YouTubeDataSample {
					Title = yv.Snippet.Title,
					Subtitle = yv.Snippet.Description,
					ChannelTitle = yv.Snippet.ChannelTitle,
					Link = yv.Link,
					Thumbnail = yv.Snippet.Thumbnails.Default.Url
				});

			return dataToAppend;
		}
	}

	partial class OnDemandSampleViewController : UIViewController
	{
		public OnDemandSampleViewController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			Dictionary<string, NSData> dic = new Dictionary<string, NSData> ();

			this.flexGrid.IsReadOnly = false;
			this.flexGrid.AutoGenerateColumns = false;
			this.flexGrid.ColumnHeaderFont = UIFont.BoldSystemFontOfSize (this.flexGrid.Font.PointSize);

			GridColumn[] columns = new[] { 
				new GridColumn { Binding = "Thumbnail", Width = 150 },
				new GridColumn { Binding = "Title", WordWrap = true },
				new GridColumn { Binding = "ChannelTitle", WordWrap = true }
			};

			this.flexGrid.Columns.AddRange (columns);

			this.flexGrid.LoadedRows += (sender, e) => {
				foreach (GridRow rz in this.flexGrid.Rows)
					rz.Height = 75;
			};
	

			this.flexGrid.FormatItem += (FlexGrid sender, GridPanel panel, GridCellRange range, CoreGraphics.CGContext context) => {
				if (panel.CellType == GridCellType.Cell && sender.Columns[range.Col].Binding.Equals ("Thumbnail")) {
					YouTubeDataSample sample = (YouTubeDataSample)sender.CollectionView[range.Row];
					NSData thisimgdata = null;
					if (dic.TryGetValue (sample.Thumbnail, out thisimgdata)) {
						UIImage img = new UIImage(thisimgdata);
						CGRect rect = panel.GetCellRect(range.Row, range.Col);
				
						CGSize imageSize = img.Size;
						CGSize viewSize = rect.Size;

						nfloat hfactor = imageSize.Width / viewSize.Width;
						nfloat vfactor = imageSize.Height / viewSize.Height;

						nfloat factor = (nfloat)Math.Max(hfactor, vfactor);

						nfloat newWidth = imageSize.Width / factor;
						nfloat newHeight = imageSize.Height / factor;

						CGRect newRect = new CGRect(rect.Location.X+(rect.Size.Width-newWidth)/2,rect.Location.Y+(rect.Size.Height-newHeight)/2, newWidth, newHeight);

						img.Draw(newRect);

					} else {
						InvokeInBackground (() => {
							thisimgdata = NSData.FromUrl (new NSUrl (sample.Thumbnail));
							InvokeOnMainThread (() => {
								dic[sample.Thumbnail] = thisimgdata;
								this.flexGrid.Invalidate();
							});
						});
					}
					return true;	
				}
				return false;
			};

			this.UpdateSearch ();
		}

		private void UpdateSearch()
		{
			string[] searchModes = new string[]{ "relevance", "date", "viewCount", "rating", "title" };
				
			this.flexGrid.CollectionView = new YouTubeCollectionView (this.searchText.Text, searchModes[this.sortModeSelector.SelectedSegment]);
		}

		partial void sortModeChanged (UISegmentedControl sender)
		{
			this.UpdateSearch();
		}

		partial void doSearch (UITextField sender)
		{
			sender.ResignFirstResponder();
			this.UpdateSearch();
		}
	}


	[DataContract]
	public class YouTubeSearchResult
	{
		[DataMember (Name = "nextPageToken")]
		public string NextPageToken { get; set; }

		[DataMember (Name = "items")]
		public YouTubeSearchItemResult[] Items { get; set; }
	}

	[DataContract]
	public class YouTubeSearchItemResult
	{
		[DataMember (Name = "id")]
		public YouTubeVideoId Id { get; set; }

		[DataMember (Name = "snippet")]
		public YouTubeSnippet Snippet { get; set; }
	}

	[DataContract]
	public class YouTubeVideoId
	{
		[DataMember (Name = "videoId")]
		public string VideoId { get; set; }
	}

	[DataContract]
	public class YouTubeSnippet
	{
		[DataMember (Name = "title")]
		public string Title { get; set; }

		[DataMember (Name = "description")]
		public string Description { get; set; }

		[DataMember (Name = "thumbnails")]
		public YouTubeThumbnails Thumbnails { get; set; }

		[DataMember (Name = "channelTitle")]
		public string ChannelTitle { get; set; }
	}

	[DataContract]
	public class YouTubeThumbnails
	{
		[DataMember (Name = "default")]
		public YouTubeThumbnail Default { get; set; }

		[DataMember (Name = "medium")]
		public YouTubeThumbnail Medium { get; set; }

		[DataMember (Name = "high")]
		public YouTubeThumbnail High { get; set; }
	}

	[DataContract]
	public class YouTubeThumbnail
	{
		[DataMember (Name = "url")]
		public string Url { get; set; }
	}

	[DataContract]
	public class YouTubeVideo
	{
		[DataMember (Name = "kind")]
		public string Kind { get; set; }

		[DataMember (Name = "etag")]
		public string Etag { get; set; }

		[DataMember (Name = "id")]
		public string Id { get; set; }

		[DataMember (Name = "snippet")]
		public YouTubeVideoSnippet Snippet { get; set; }

		[DataMember (Name = "statistics")]
		public YouTubeVideoStatistics Statistics { get; set; }

		public string Link {
			get {
				return "http://www.youtube.com/watch?v=" + Id;
			}
		}
	}

	[DataContract]
	public class YouTubeVideoSnippet
	{
		[DataMember (Name = "title")]
		public string Title { get; set; }

		[DataMember (Name = "description")]
		public string Description { get; set; }

		[DataMember (Name = "thumbnails")]
		public YouTubeThumbnails Thumbnails { get; set; }

		[DataMember (Name = "channelTitle")]
		public string ChannelTitle { get; set; }
	}

	[DataContract]
	public class YouTubeVideoStatistics
	{
		[DataMember (Name = "viewCount")]
		public ulong ViewCount { get; set; }

		[DataMember (Name = "likeCount")]
		public ulong LikeCount { get; set; }

		[DataMember (Name = "dislikeCount")]
		public ulong DislikeCount { get; set; }

		[DataMember (Name = "favoriteCount")]
		public ulong FavoriteCount { get; set; }

		[DataMember (Name = "commentCount")]
		public ulong CommentCount { get; set; }
	}

	[DataContract]
	public class YouTubeVideoListResult
	{
		[DataMember (Name = "nextPageToken")]
		public string NextPageToken { get; set; }

		[DataMember (Name = "items")]
		public YouTubeVideo[] Items { get; set; }
	}

	public class YouTubeDataSample
	{
		[Export ("Title")]
		public string Title { get; set; }

		[Export ("Subtitle")]
		public string Subtitle { get; set; }

		[Export ("Thumbnail")]
		public string Thumbnail { get; set; }

		[Export ("Link")]
		public string Link { get; set; }

		[Export ("ChannelTitle")]
		public string ChannelTitle { get; set; }
	}
}
	
