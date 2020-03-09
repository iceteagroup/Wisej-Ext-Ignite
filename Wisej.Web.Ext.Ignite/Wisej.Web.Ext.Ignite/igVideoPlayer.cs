///////////////////////////////////////////////////////////////////////////////
//
// (C) 2020 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////


using System.ComponentModel;

namespace Wisej.Web.Ext.Ignite
{
	/// <summary>
	/// The igVideoPlayer is a jQuery UI widget that displays HTML5 video 
	/// displaying a consistent user interface across browsers.
	/// </summary>
	public class igVideoPlayer : igBase
	{

		#region Constructors

		/// <summary>
		/// Constructs a new instance of the <see cref="igVideoPlayer"/> class.
		/// </summary>
		public igVideoPlayer() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="igVideoPlayer"/> class.
		/// </summary>
		/// <param name="options"></param>
		public igVideoPlayer(object options) : base("igVideoPlayer", options)
		{
			if (!this.Packages.Exists(i => { return i.Name.Equals(""); }))
			{

			}

			this.WidgetWiredEvents = new[] {
			"bannerClick",
			"bannerHidden",
			"bannerVisible",
			"bookmarkClick",
			"bookmarkHit",
			"browserNotSupported",
			"buffering",
			"ended",
			"enterFullScreen",
			"exitFullScreen",
			"paused",
			"playing",
			"progress",
			"relatedVideoClick",
			"waiting"
			};
		}

		#endregion

		#region Widget Properties

		/// <summary>
		/// Not applicable for this control
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Text { get => base.Text; set => base.Text = value; }

		/// <summary>
		/// Specifies the duration of the current video
		/// </summary>
		public double Duration
		{
			get
			{
				return this.Options.duration ?? 0.0;
			}
		}

		#endregion

		#region Widget Functions

		/// <summary>
		/// Tells the widget to start playing the video
		/// </summary>
		public void Play()
		{
			this.Widget.play();
		}

		/// <summary>
		/// Tells the widget to pause the video
		/// </summary>
		public void Pause()
		{
			this.Widget.pause();
		}

		#endregion
	}
}
