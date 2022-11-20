using Microsoft.VisualStudio.Imaging;

using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace EngineeringXTensions;
public class MyToolWindow: BaseToolWindow<MyToolWindow>
{
	public override string GetTitle( int toolWindowId ) => "My Tool Window";

	public override Type PaneType => typeof( Pane );

	public override Task<FrameworkElement> CreateAsync( int toolWindowId, CancellationToken cancellationToken ) {
		return Task.FromResult<FrameworkElement>( new MyToolWindowControl() );
	}

	[Guid( "b3c14840-760f-4dba-9355-2be1042aee4c" )]
	internal class Pane: ToolkitToolWindowPane
	{
		public Pane() {
			BitmapImageMoniker = KnownMonikers.ToolWindow;
		}
	}
}