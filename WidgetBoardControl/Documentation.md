# WidgetBoard (WPF)
 | [ReadMe](../README.md) | Documentation | 

## Contents

- [ActionsWidgetHandler](#T-WidgetBoardControl-Widget-ActionsWidgetHandler 'WidgetBoardControl.Widget.ActionsWidgetHandler')
- [IUserWidgetViewModel](#T-WidgetBoardControl-IUserWidgetViewModel 'WidgetBoardControl.IUserWidgetViewModel')
  - [Settings](#P-WidgetBoardControl-IUserWidgetViewModel-Settings 'WidgetBoardControl.IUserWidgetViewModel.Settings')
- [OnCreateWidget](#T-WidgetBoardControl-WidgetPalette-OnCreateWidget 'WidgetBoardControl.WidgetPalette.OnCreateWidget')
- [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget')
- [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget')
  - [#ctor(userControl)](#M-WidgetBoardControl-Views-Widget-#ctor-System-Windows-Controls-UserControl- 'WidgetBoardControl.Views.Widget.#ctor(System.Windows.Controls.UserControl)')
  - [#ctor(widgetControl,widgetViewModel,widgetId)](#M-WidgetBoardControl-Widget-#ctor-System-Windows-Controls-UserControl,System-Object,System-Guid- 'WidgetBoardControl.Widget.#ctor(System.Windows.Controls.UserControl,System.Object,System.Guid)')
  - [Column](#P-WidgetBoardControl-Views-Widget-Column 'WidgetBoardControl.Views.Widget.Column')
  - [ColumnSpan](#P-WidgetBoardControl-Views-Widget-ColumnSpan 'WidgetBoardControl.Views.Widget.ColumnSpan')
  - [ManipulatorVisibility](#P-WidgetBoardControl-Views-Widget-ManipulatorVisibility 'WidgetBoardControl.Views.Widget.ManipulatorVisibility')
  - [MinColumnSpan](#P-WidgetBoardControl-Views-Widget-MinColumnSpan 'WidgetBoardControl.Views.Widget.MinColumnSpan')
  - [MinRowSpan](#P-WidgetBoardControl-Views-Widget-MinRowSpan 'WidgetBoardControl.Views.Widget.MinRowSpan')
  - [Row](#P-WidgetBoardControl-Views-Widget-Row 'WidgetBoardControl.Views.Widget.Row')
  - [RowSpan](#P-WidgetBoardControl-Views-Widget-RowSpan 'WidgetBoardControl.Views.Widget.RowSpan')
  - [SettingsButtonVisibility](#P-WidgetBoardControl-Views-Widget-SettingsButtonVisibility 'WidgetBoardControl.Views.Widget.SettingsButtonVisibility')
  - [ShadowOpacity](#P-WidgetBoardControl-Views-Widget-ShadowOpacity 'WidgetBoardControl.Views.Widget.ShadowOpacity')
  - [Column](#P-WidgetBoardControl-Widget-Column 'WidgetBoardControl.Widget.Column')
  - [ColumnSpan](#P-WidgetBoardControl-Widget-ColumnSpan 'WidgetBoardControl.Widget.ColumnSpan')
  - [IsManipulatorVisible](#P-WidgetBoardControl-Widget-IsManipulatorVisible 'WidgetBoardControl.Widget.IsManipulatorVisible')
  - [IsSettingsButtonVisible](#P-WidgetBoardControl-Widget-IsSettingsButtonVisible 'WidgetBoardControl.Widget.IsSettingsButtonVisible')
  - [MinColumnSpan](#P-WidgetBoardControl-Widget-MinColumnSpan 'WidgetBoardControl.Widget.MinColumnSpan')
  - [MinRowSpan](#P-WidgetBoardControl-Widget-MinRowSpan 'WidgetBoardControl.Widget.MinRowSpan')
  - [RemoveCommand](#P-WidgetBoardControl-Widget-RemoveCommand 'WidgetBoardControl.Widget.RemoveCommand')
  - [Row](#P-WidgetBoardControl-Widget-Row 'WidgetBoardControl.Widget.Row')
  - [RowSpan](#P-WidgetBoardControl-Widget-RowSpan 'WidgetBoardControl.Widget.RowSpan')
  - [Settings](#P-WidgetBoardControl-Widget-Settings 'WidgetBoardControl.Widget.Settings')
  - [SettingsCommand](#P-WidgetBoardControl-Widget-SettingsCommand 'WidgetBoardControl.Widget.SettingsCommand')
  - [ShadowOpacity](#P-WidgetBoardControl-Widget-ShadowOpacity 'WidgetBoardControl.Widget.ShadowOpacity')
  - [Title](#P-WidgetBoardControl-Widget-Title 'WidgetBoardControl.Widget.Title')
  - [WidgetId](#P-WidgetBoardControl-Widget-WidgetId 'WidgetBoardControl.Widget.WidgetId')
  - [WidgetView](#P-WidgetBoardControl-Widget-WidgetView 'WidgetBoardControl.Widget.WidgetView')
  - [#cctor()](#M-WidgetBoardControl-Views-Widget-#cctor 'WidgetBoardControl.Views.Widget.#cctor')
  - [HeaderMouseLeftButtonDownHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-HeaderMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WidgetBoardControl.Views.Widget.HeaderMouseLeftButtonDownHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [HeaderMouseLeftButtonUpHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-HeaderMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WidgetBoardControl.Views.Widget.HeaderMouseLeftButtonUpHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [HeaderMouseMoveHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-HeaderMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs- 'WidgetBoardControl.Views.Widget.HeaderMouseMoveHandler(System.Object,System.Windows.Input.MouseEventArgs)')
  - [HeightAnimation_Completed(sender,e)](#M-WidgetBoardControl-Views-Widget-HeightAnimation_Completed-System-Object,System-EventArgs- 'WidgetBoardControl.Views.Widget.HeightAnimation_Completed(System.Object,System.EventArgs)')
  - [InitializeComponent()](#M-WidgetBoardControl-Views-Widget-InitializeComponent 'WidgetBoardControl.Views.Widget.InitializeComponent')
  - [InitializeOnBoard()](#M-WidgetBoardControl-Views-Widget-InitializeOnBoard 'WidgetBoardControl.Views.Widget.InitializeOnBoard')
  - [LeftAnimation_Completed(sender,e)](#M-WidgetBoardControl-Views-Widget-LeftAnimation_Completed-System-Object,System-EventArgs- 'WidgetBoardControl.Views.Widget.LeftAnimation_Completed(System.Object,System.EventArgs)')
  - [OnColumnChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnColumnChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnColumnChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnColumnSpanChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnColumnSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnManipulatorVisibilityChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnManipulatorVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnManipulatorVisibilityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnMinColumnSpanChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnMinColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnMinColumnSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnMinRowSpanChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnMinRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnMinRowSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnRowChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnRowChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnRowChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnRowSpanChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnRowSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnSettingsButtonVisibilityChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnSettingsButtonVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnSettingsButtonVisibilityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnShadowOpacityChanged(d,e)](#M-WidgetBoardControl-Views-Widget-OnShadowOpacityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.Widget.OnShadowOpacityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [ResizeMouseLeftButtonDownHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-ResizeMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WidgetBoardControl.Views.Widget.ResizeMouseLeftButtonDownHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [ResizeMouseLeftButtonUpHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-ResizeMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WidgetBoardControl.Views.Widget.ResizeMouseLeftButtonUpHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [ResizeMouseMoveHandler(sender,e)](#M-WidgetBoardControl-Views-Widget-ResizeMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs- 'WidgetBoardControl.Views.Widget.ResizeMouseMoveHandler(System.Object,System.Windows.Input.MouseEventArgs)')
  - [SetCellHeight(value)](#M-WidgetBoardControl-Views-Widget-SetCellHeight-System-Double- 'WidgetBoardControl.Views.Widget.SetCellHeight(System.Double)')
  - [SetCellWidth(value)](#M-WidgetBoardControl-Views-Widget-SetCellWidth-System-Double- 'WidgetBoardControl.Views.Widget.SetCellWidth(System.Double)')
  - [TopAnimation_Completed(sender,e)](#M-WidgetBoardControl-Views-Widget-TopAnimation_Completed-System-Object,System-EventArgs- 'WidgetBoardControl.Views.Widget.TopAnimation_Completed(System.Object,System.EventArgs)')
  - [WidthAnimation_Completed(sender,e)](#M-WidgetBoardControl-Views-Widget-WidthAnimation_Completed-System-Object,System-EventArgs- 'WidgetBoardControl.Views.Widget.WidthAnimation_Completed(System.Object,System.EventArgs)')
  - [OnPropertyChanged(prop)](#M-WidgetBoardControl-Widget-OnPropertyChanged-System-String- 'WidgetBoardControl.Widget.OnPropertyChanged(System.String)')
  - [SetCellHeight(value)](#M-WidgetBoardControl-Widget-SetCellHeight-System-Double- 'WidgetBoardControl.Widget.SetCellHeight(System.Double)')
  - [SetCellWidth(value)](#M-WidgetBoardControl-Widget-SetCellWidth-System-Double- 'WidgetBoardControl.Widget.SetCellWidth(System.Double)')
- [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard')
  - [#ctor()](#M-WidgetBoardControl-Views-WidgetBoard-#ctor 'WidgetBoardControl.Views.WidgetBoard.#ctor')
  - [AutoCellSize](#P-WidgetBoardControl-Views-WidgetBoard-AutoCellSize 'WidgetBoardControl.Views.WidgetBoard.AutoCellSize')
  - [BoardBackground](#P-WidgetBoardControl-Views-WidgetBoard-BoardBackground 'WidgetBoardControl.Views.WidgetBoard.BoardBackground')
  - [BoardForeground](#P-WidgetBoardControl-Views-WidgetBoard-BoardForeground 'WidgetBoardControl.Views.WidgetBoard.BoardForeground')
  - [CellHeight](#P-WidgetBoardControl-Views-WidgetBoard-CellHeight 'WidgetBoardControl.Views.WidgetBoard.CellHeight')
  - [CellWidth](#P-WidgetBoardControl-Views-WidgetBoard-CellWidth 'WidgetBoardControl.Views.WidgetBoard.CellWidth')
  - [GridColumnCount](#P-WidgetBoardControl-Views-WidgetBoard-GridColumnCount 'WidgetBoardControl.Views.WidgetBoard.GridColumnCount')
  - [GridRowCount](#P-WidgetBoardControl-Views-WidgetBoard-GridRowCount 'WidgetBoardControl.Views.WidgetBoard.GridRowCount')
  - [IsGridDisplayed](#P-WidgetBoardControl-Views-WidgetBoard-IsGridDisplayed 'WidgetBoardControl.Views.WidgetBoard.IsGridDisplayed')
  - [IsManipulatorHidden](#P-WidgetBoardControl-Views-WidgetBoard-IsManipulatorHidden 'WidgetBoardControl.Views.WidgetBoard.IsManipulatorHidden')
  - [IsSidebarHidden](#P-WidgetBoardControl-Views-WidgetBoard-IsSidebarHidden 'WidgetBoardControl.Views.WidgetBoard.IsSidebarHidden')
  - [PaletteBackground](#P-WidgetBoardControl-Views-WidgetBoard-PaletteBackground 'WidgetBoardControl.Views.WidgetBoard.PaletteBackground')
  - [PaletteForeground](#P-WidgetBoardControl-Views-WidgetBoard-PaletteForeground 'WidgetBoardControl.Views.WidgetBoard.PaletteForeground')
  - [SidebarWidth](#P-WidgetBoardControl-Views-WidgetBoard-SidebarWidth 'WidgetBoardControl.Views.WidgetBoard.SidebarWidth')
  - [WidgetsOnBoard](#P-WidgetBoardControl-Views-WidgetBoard-WidgetsOnBoard 'WidgetBoardControl.Views.WidgetBoard.WidgetsOnBoard')
  - [WidgetsPalette](#P-WidgetBoardControl-Views-WidgetBoard-WidgetsPalette 'WidgetBoardControl.Views.WidgetBoard.WidgetsPalette')
  - [#cctor()](#M-WidgetBoardControl-Views-WidgetBoard-#cctor 'WidgetBoardControl.Views.WidgetBoard.#cctor')
  - [AddWidget(widget)](#M-WidgetBoardControl-Views-WidgetBoard-AddWidget-WidgetBoardControl-Widget- 'WidgetBoardControl.Views.WidgetBoard.AddWidget(WidgetBoardControl.Widget)')
  - [InitializeComponent()](#M-WidgetBoardControl-Views-WidgetBoard-InitializeComponent 'WidgetBoardControl.Views.WidgetBoard.InitializeComponent')
  - [OnAutoCellSizeChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnAutoCellSizeChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnAutoCellSizeChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnBoardBackgroundChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnBoardBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnBoardBackgroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnBoardChangedHandler(sender,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnBoardChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnBoardChangedHandler(System.Object,System.Collections.Specialized.NotifyCollectionChangedEventArgs)')
  - [OnBoardForegroundChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnBoardForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnBoardForegroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCellHeightChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnCellHeightChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnCellHeightChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCellWidthChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnCellWidthChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnCellWidthChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCreateWidgetHandler(sender,widget)](#M-WidgetBoardControl-Views-WidgetBoard-OnCreateWidgetHandler-System-Object,WidgetBoardControl-Widget- 'WidgetBoardControl.Views.WidgetBoard.OnCreateWidgetHandler(System.Object,WidgetBoardControl.Widget)')
  - [OnGridColumnCountChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnGridColumnCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnGridColumnCountChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnGridRowCountChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnGridRowCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnGridRowCountChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsGridDisplayedChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnIsGridDisplayedChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnIsGridDisplayedChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsManipulatorHiddenChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnIsManipulatorHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnIsManipulatorHiddenChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsSidebarHiddenChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnIsSidebarHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnIsSidebarHiddenChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnLoad(sender)](#M-WidgetBoardControl-Views-WidgetBoard-OnLoad-System-Object,System-Windows-RoutedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnLoad(System.Object,System.Windows.RoutedEventArgs)')
  - [OnPaletteBackgroundChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnPaletteBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnPaletteBackgroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnPaletteChangedHandler(sender,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnPaletteChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnPaletteChangedHandler(System.Object,System.Collections.Specialized.NotifyCollectionChangedEventArgs)')
  - [OnPaletteForegroundChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnPaletteForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnPaletteForegroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnSizeChanged(sender,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnSizeChanged(System.Object,System.Windows.SizeChangedEventArgs)')
  - [OnWidgetsOnBoardChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnWidgetsOnBoardChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnWidgetsOnBoardChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnWidgetsPaletteChanged(d,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnWidgetsPaletteChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnWidgetsPaletteChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnWidthAnimationCompletedHandler(sender,e)](#M-WidgetBoardControl-Views-WidgetBoard-OnWidthAnimationCompletedHandler-System-Object,System-EventArgs- 'WidgetBoardControl.Views.WidgetBoard.OnWidthAnimationCompletedHandler(System.Object,System.EventArgs)')
  - [RemoveWidget(widget)](#M-WidgetBoardControl-Views-WidgetBoard-RemoveWidget-WidgetBoardControl-Widget- 'WidgetBoardControl.Views.WidgetBoard.RemoveWidget(WidgetBoardControl.Widget)')
  - [RenderWidgetPalette()](#M-WidgetBoardControl-Views-WidgetBoard-RenderWidgetPalette 'WidgetBoardControl.Views.WidgetBoard.RenderWidgetPalette')
  - [ResizeGrid()](#M-WidgetBoardControl-Views-WidgetBoard-ResizeGrid 'WidgetBoardControl.Views.WidgetBoard.ResizeGrid')
  - [ToggleAutoCellSize()](#M-WidgetBoardControl-Views-WidgetBoard-ToggleAutoCellSize 'WidgetBoardControl.Views.WidgetBoard.ToggleAutoCellSize')
  - [ToggleWidgetManipulators()](#M-WidgetBoardControl-Views-WidgetBoard-ToggleWidgetManipulators 'WidgetBoardControl.Views.WidgetBoard.ToggleWidgetManipulators')
  - [ToggleWidgetSidebar()](#M-WidgetBoardControl-Views-WidgetBoard-ToggleWidgetSidebar 'WidgetBoardControl.Views.WidgetBoard.ToggleWidgetSidebar')
  - [UpdateGridDimensions()](#M-WidgetBoardControl-Views-WidgetBoard-UpdateGridDimensions 'WidgetBoardControl.Views.WidgetBoard.UpdateGridDimensions')
- [WidgetPalette](#T-WidgetBoardControl-Views-WidgetPalette 'WidgetBoardControl.Views.WidgetPalette')
- [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette')
  - [#ctor()](#M-WidgetBoardControl-Views-WidgetPalette-#ctor 'WidgetBoardControl.Views.WidgetPalette.#ctor')
  - [#ctor(widgetType,widgetControlType,widgetViewModelType)](#M-WidgetBoardControl-WidgetPalette-#ctor-System-Type,System-Type,System-Type- 'WidgetBoardControl.WidgetPalette.#ctor(System.Type,System.Type,System.Type)')
  - [CreateWidgetCommand](#P-WidgetBoardControl-WidgetPalette-CreateWidgetCommand 'WidgetBoardControl.WidgetPalette.CreateWidgetCommand')
  - [GroupName](#P-WidgetBoardControl-WidgetPalette-GroupName 'WidgetBoardControl.WidgetPalette.GroupName')
  - [IconBase64](#P-WidgetBoardControl-WidgetPalette-IconBase64 'WidgetBoardControl.WidgetPalette.IconBase64')
  - [IconBytes](#P-WidgetBoardControl-WidgetPalette-IconBytes 'WidgetBoardControl.WidgetPalette.IconBytes')
  - [Title](#P-WidgetBoardControl-WidgetPalette-Title 'WidgetBoardControl.WidgetPalette.Title')
  - [WidgetId](#P-WidgetBoardControl-WidgetPalette-WidgetId 'WidgetBoardControl.WidgetPalette.WidgetId')
  - [WidgetPaletteView](#P-WidgetBoardControl-WidgetPalette-WidgetPaletteView 'WidgetBoardControl.WidgetPalette.WidgetPaletteView')
  - [InitializeComponent()](#M-WidgetBoardControl-Views-WidgetPalette-InitializeComponent 'WidgetBoardControl.Views.WidgetPalette.InitializeComponent')
  - [CreateWidgetInstance()](#M-WidgetBoardControl-WidgetPalette-CreateWidgetInstance 'WidgetBoardControl.WidgetPalette.CreateWidgetInstance')
  - [OnPropertyChanged(prop)](#M-WidgetBoardControl-WidgetPalette-OnPropertyChanged-System-String- 'WidgetBoardControl.WidgetPalette.OnPropertyChanged(System.String)')

<a name='T-WidgetBoardControl-Widget-ActionsWidgetHandler'></a>
## ActionsWidgetHandler `type`

##### Namespace

WidgetBoardControl.Widget

##### Summary

Describes the signature of an event handler that fires when an action occurs on a widget.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:WidgetBoardControl.Widget.ActionsWidgetHandler](#T-T-WidgetBoardControl-Widget-ActionsWidgetHandler 'T:WidgetBoardControl.Widget.ActionsWidgetHandler') | Widget on which the action takes place |

<a name='T-WidgetBoardControl-IUserWidgetViewModel'></a>
## IUserWidgetViewModel `type`

##### Namespace

WidgetBoardControl

##### Summary

Declares properties for working with widget settings

<a name='P-WidgetBoardControl-IUserWidgetViewModel-Settings'></a>
### Settings `property`

##### Summary

Gets or sets the settings of widget

<a name='T-WidgetBoardControl-WidgetPalette-OnCreateWidget'></a>
## OnCreateWidget `type`

##### Namespace

WidgetBoardControl.WidgetPalette

##### Summary

Describes the signature of event handlers that fire when [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') are created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:WidgetBoardControl.WidgetPalette.OnCreateWidget](#T-T-WidgetBoardControl-WidgetPalette-OnCreateWidget 'T:WidgetBoardControl.WidgetPalette.OnCreateWidget') | The object that triggered the event |

<a name='T-WidgetBoardControl-Views-Widget'></a>
## Widget `type`

##### Namespace

WidgetBoardControl.Views

##### Summary

Represents a Widget item on a [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard').

<a name='T-WidgetBoardControl-Widget'></a>
## Widget `type`

##### Namespace

WidgetBoardControl

##### Summary

Represents a view model for [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') that can be placed on a
    [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard').

<a name='M-WidgetBoardControl-Views-Widget-#ctor-System-Windows-Controls-UserControl-'></a>
### #ctor(userControl) `constructor`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userControl | [System.Windows.Controls.UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') |  |

<a name='M-WidgetBoardControl-Widget-#ctor-System-Windows-Controls-UserControl,System-Object,System-Guid-'></a>
### #ctor(widgetControl,widgetViewModel,widgetId) `constructor`

##### Summary

Class that represents the view model of a [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') on a widget board.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widgetControl | [System.Windows.Controls.UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') | [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') to be included in the widget |
| widgetViewModel | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ViewModel object for WidgetControl |
| widgetId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Widget type ID |

<a name='P-WidgetBoardControl-Views-Widget-Column'></a>
### Column `property`

##### Summary

Gets or sets the X-position on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-ColumnSpan'></a>
### ColumnSpan `property`

##### Summary

Gets or sets the width on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-ManipulatorVisibility'></a>
### ManipulatorVisibility `property`

##### Summary

Gets or sets the visibility state of Widget manipulator

<a name='P-WidgetBoardControl-Views-Widget-MinColumnSpan'></a>
### MinColumnSpan `property`

##### Summary

Gets or sets the minimal Widget width (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-MinRowSpan'></a>
### MinRowSpan `property`

##### Summary

Gets or sets the minimal Widget height (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-Row'></a>
### Row `property`

##### Summary

Gets or sets the Y-position on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-RowSpan'></a>
### RowSpan `property`

##### Summary

Gets or sets the height on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Views-Widget-SettingsButtonVisibility'></a>
### SettingsButtonVisibility `property`

##### Summary

Gets or sets the visibility of the settings button

<a name='P-WidgetBoardControl-Views-Widget-ShadowOpacity'></a>
### ShadowOpacity `property`

##### Summary

The transparency of the shadow cast by the widget

<a name='P-WidgetBoardControl-Widget-Column'></a>
### Column `property`

##### Summary

Gets or sets the X-position on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Widget-ColumnSpan'></a>
### ColumnSpan `property`

##### Summary

Gets or sets the width on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Widget-IsManipulatorVisible'></a>
### IsManipulatorVisible `property`

##### Summary

Gets or sets the flag representing the visibility state of controls

<a name='P-WidgetBoardControl-Widget-IsSettingsButtonVisible'></a>
### IsSettingsButtonVisible `property`

##### Summary

Gets or sets the flag representing the visibility state of Settings Button in header

<a name='P-WidgetBoardControl-Widget-MinColumnSpan'></a>
### MinColumnSpan `property`

##### Summary

Gets or sets the minimal Widget width (measured in cells)

<a name='P-WidgetBoardControl-Widget-MinRowSpan'></a>
### MinRowSpan `property`

##### Summary

Gets or sets the minimal Widget height (measured in cells)

<a name='P-WidgetBoardControl-Widget-RemoveCommand'></a>
### RemoveCommand `property`

##### Summary

Command that triggered [](#E-WidgetBoardControl-Widget-OnRemoveWidgetEvent 'WidgetBoardControl.Widget.OnRemoveWidgetEvent')

<a name='P-WidgetBoardControl-Widget-Row'></a>
### Row `property`

##### Summary

Gets or sets the widget height on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Widget-RowSpan'></a>
### RowSpan `property`

##### Summary

Gets or sets the height on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') (measured in cells)

<a name='P-WidgetBoardControl-Widget-Settings'></a>
### Settings `property`

##### Summary

Gets or sets the custom settings for saving state in serialized data

<a name='P-WidgetBoardControl-Widget-SettingsCommand'></a>
### SettingsCommand `property`

##### Summary

Command that triggered [](#E-WidgetBoardControl-Widget-OnSettingsWidgetEvent 'WidgetBoardControl.Widget.OnSettingsWidgetEvent')

<a name='P-WidgetBoardControl-Widget-ShadowOpacity'></a>
### ShadowOpacity `property`

##### Summary

Gets or sets the transparency value of the shadow cast by the widget

<a name='P-WidgetBoardControl-Widget-Title'></a>
### Title `property`

##### Summary

Gets or sets the title displayed in the interface of the [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget')

<a name='P-WidgetBoardControl-Widget-WidgetId'></a>
### WidgetId `property`

##### Summary

Gets or protected sets the widget variant ID

<a name='P-WidgetBoardControl-Widget-WidgetView'></a>
### WidgetView `property`

##### Summary

Completed widget presentation for placement on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard')

<a name='M-WidgetBoardControl-Views-Widget-#cctor'></a>
### #cctor() `method`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-Widget-HeaderMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### HeaderMouseLeftButtonDownHandler(sender,e) `method`

##### Summary

Handler called when Widget Drag start

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-WidgetBoardControl-Views-Widget-HeaderMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### HeaderMouseLeftButtonUpHandler(sender,e) `method`

##### Summary

Handler called when Widget Drag end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-WidgetBoardControl-Views-Widget-HeaderMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs-'></a>
### HeaderMouseMoveHandler(sender,e) `method`

##### Summary

Handler called during Widget Drag

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseEventArgs 'System.Windows.Input.MouseEventArgs') | Provides data for mouse position events |

<a name='M-WidgetBoardControl-Views-Widget-HeightAnimation_Completed-System-Object,System-EventArgs-'></a>
### HeightAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Height animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-WidgetBoardControl-Views-Widget-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-Widget-InitializeOnBoard'></a>
### InitializeOnBoard() `method`

##### Summary

Update Widget transformation on [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard')

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-Widget-LeftAnimation_Completed-System-Object,System-EventArgs-'></a>
### LeftAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the X-position animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-WidgetBoardControl-Views-Widget-OnColumnChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnColumnChanged(d,e) `method`

##### Summary

Handler called when the Column changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnColumnSpanChanged(d,e) `method`

##### Summary

Handler called when the ColumnSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnManipulatorVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnManipulatorVisibilityChanged(d,e) `method`

##### Summary

Handler called when the Manipulator Visibility changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnMinColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnMinColumnSpanChanged(d,e) `method`

##### Summary

Handler called when the Minimal ColumnSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnMinRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnMinRowSpanChanged(d,e) `method`

##### Summary

Handler called when the Minimal RowSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnRowChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnRowChanged(d,e) `method`

##### Summary

Handler called when the Row changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnRowSpanChanged(d,e) `method`

##### Summary

Handler called when the RowSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnSettingsButtonVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnSettingsButtonVisibilityChanged(d,e) `method`

##### Summary

Handler that is called when the visibility state changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-OnShadowOpacityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnShadowOpacityChanged(d,e) `method`

##### Summary

Handler that is called when the shadow opacity changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-Widget-ResizeMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ResizeMouseLeftButtonDownHandler(sender,e) `method`

##### Summary

Handler called when Widget Resize start

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-WidgetBoardControl-Views-Widget-ResizeMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ResizeMouseLeftButtonUpHandler(sender,e) `method`

##### Summary

Handler called when Widget Resize end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-WidgetBoardControl-Views-Widget-ResizeMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs-'></a>
### ResizeMouseMoveHandler(sender,e) `method`

##### Summary

Handler called during Widget Resize

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseEventArgs 'System.Windows.Input.MouseEventArgs') | Provides data for mouse position events |

<a name='M-WidgetBoardControl-Views-Widget-SetCellHeight-System-Double-'></a>
### SetCellHeight(value) `method`

##### Summary

Set new cell height and then update transform

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New cell height |

<a name='M-WidgetBoardControl-Views-Widget-SetCellWidth-System-Double-'></a>
### SetCellWidth(value) `method`

##### Summary

Set new cell width and then update transform

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New cell width |

<a name='M-WidgetBoardControl-Views-Widget-TopAnimation_Completed-System-Object,System-EventArgs-'></a>
### TopAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Y-position animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-WidgetBoardControl-Views-Widget-WidthAnimation_Completed-System-Object,System-EventArgs-'></a>
### WidthAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Width animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-WidgetBoardControl-Widget-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(prop) `method`

##### Summary

Method that do trigger [](#E-WidgetBoardControl-Widget-PropertyChanged 'WidgetBoardControl.Widget.PropertyChanged')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prop | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |

<a name='M-WidgetBoardControl-Widget-SetCellHeight-System-Double-'></a>
### SetCellHeight(value) `method`

##### Summary

Sets the cell height to use in building the interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Cell height size |

<a name='M-WidgetBoardControl-Widget-SetCellWidth-System-Double-'></a>
### SetCellWidth(value) `method`

##### Summary

Sets the cell width to use in building the interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Cell width size |

<a name='T-WidgetBoardControl-Views-WidgetBoard'></a>
## WidgetBoard `type`

##### Namespace

WidgetBoardControl.Views

##### Summary

Represent element for placing [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') and
    [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette')

<a name='M-WidgetBoardControl-Views-WidgetBoard-#ctor'></a>
### #ctor() `constructor`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This constructor has no parameters.

<a name='P-WidgetBoardControl-Views-WidgetBoard-AutoCellSize'></a>
### AutoCellSize `property`

##### Summary

Gets or sets the activity of calculated cell sizes

<a name='P-WidgetBoardControl-Views-WidgetBoard-BoardBackground'></a>
### BoardBackground `property`

##### Summary

Gets or sets the filling the background for the main widget board field

<a name='P-WidgetBoardControl-Views-WidgetBoard-BoardForeground'></a>
### BoardForeground `property`

##### Summary

Gets or sets the color for grid lines and other stuff

<a name='P-WidgetBoardControl-Views-WidgetBoard-CellHeight'></a>
### CellHeight `property`

##### Summary

Gets or sets the cell height to use in building the interface.

<a name='P-WidgetBoardControl-Views-WidgetBoard-CellWidth'></a>
### CellWidth `property`

##### Summary

Gets or sets the cell width to use in building the interface.

<a name='P-WidgetBoardControl-Views-WidgetBoard-GridColumnCount'></a>
### GridColumnCount `property`

##### Summary

Gets or sets the displayed on background grid column count

<a name='P-WidgetBoardControl-Views-WidgetBoard-GridRowCount'></a>
### GridRowCount `property`

##### Summary

Gets or sets the displayed on background grid row count

<a name='P-WidgetBoardControl-Views-WidgetBoard-IsGridDisplayed'></a>
### IsGridDisplayed `property`

##### Summary

Gets or sets the grid's rendering state

<a name='P-WidgetBoardControl-Views-WidgetBoard-IsManipulatorHidden'></a>
### IsManipulatorHidden `property`

##### Summary

Gets or sets the visibility of widget manipulators for [Widget](#T-WidgetBoardControl-Views-Widget 'WidgetBoardControl.Views.Widget')

<a name='P-WidgetBoardControl-Views-WidgetBoard-IsSidebarHidden'></a>
### IsSidebarHidden `property`

##### Summary

Gets or sets the visibility of sidebar with [WidgetPalette](#T-WidgetBoardControl-Views-WidgetPalette 'WidgetBoardControl.Views.WidgetPalette')

<a name='P-WidgetBoardControl-Views-WidgetBoard-PaletteBackground'></a>
### PaletteBackground `property`

##### Summary

Gets or sets the filling the background for the widget palette field

<a name='P-WidgetBoardControl-Views-WidgetBoard-PaletteForeground'></a>
### PaletteForeground `property`

##### Summary

Gets or sets the color for Group Labels and other stuff

<a name='P-WidgetBoardControl-Views-WidgetBoard-SidebarWidth'></a>
### SidebarWidth `property`

##### Summary

Gets or sets the sidebar width with [WidgetPalette](#T-WidgetBoardControl-Views-WidgetPalette 'WidgetBoardControl.Views.WidgetPalette')

<a name='P-WidgetBoardControl-Views-WidgetBoard-WidgetsOnBoard'></a>
### WidgetsOnBoard `property`

##### Summary

Gets or sets the collection of [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') located on a board

<a name='P-WidgetBoardControl-Views-WidgetBoard-WidgetsPalette'></a>
### WidgetsPalette `property`

##### Summary

Gets or sets the collection of [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette') located on a
    board

<a name='M-WidgetBoardControl-Views-WidgetBoard-#cctor'></a>
### #cctor() `method`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-AddWidget-WidgetBoardControl-Widget-'></a>
### AddWidget(widget) `method`

##### Summary

Add [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') to this WidgetBoard

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widget | [WidgetBoardControl.Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') | Widget to add |

<a name='M-WidgetBoardControl-Views-WidgetBoard-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnAutoCellSizeChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnAutoCellSizeChanged(d,e) `method`

##### Summary

Handler called when the [AutoCellSize](#P-WidgetBoardControl-Views-WidgetBoard-AutoCellSize 'WidgetBoardControl.Views.WidgetBoard.AutoCellSize') value changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnBoardBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnBoardBackgroundChanged(d,e) `method`

##### Summary

Handler called when the [BoardBackground](#P-WidgetBoardControl-Views-WidgetBoard-BoardBackground 'WidgetBoardControl.Views.WidgetBoard.BoardBackground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnBoardChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs-'></a>
### OnBoardChangedHandler(sender,e) `method`

##### Summary

Handler called when the [WidgetsOnBoard](#P-WidgetBoardControl-Views-WidgetBoard-WidgetsOnBoard 'WidgetBoardControl.Views.WidgetBoard.WidgetsOnBoard') collection changed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.Collections.Specialized.NotifyCollectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.NotifyCollectionChangedEventArgs 'System.Collections.Specialized.NotifyCollectionChangedEventArgs') | An object that describes a change in a collection |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnBoardForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnBoardForegroundChanged(d,e) `method`

##### Summary

Handler called when the [BoardForeground](#P-WidgetBoardControl-Views-WidgetBoard-BoardForeground 'WidgetBoardControl.Views.WidgetBoard.BoardForeground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnCellHeightChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnCellHeightChanged(d,e) `method`

##### Summary

Handler called when the [CellHeight](#P-WidgetBoardControl-Views-WidgetBoard-CellHeight 'WidgetBoardControl.Views.WidgetBoard.CellHeight') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnCellWidthChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnCellWidthChanged(d,e) `method`

##### Summary

Handler called when the [CellWidth](#P-WidgetBoardControl-Views-WidgetBoard-CellWidth 'WidgetBoardControl.Views.WidgetBoard.CellWidth') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') |  |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnCreateWidgetHandler-System-Object,WidgetBoardControl-Widget-'></a>
### OnCreateWidgetHandler(sender,widget) `method`

##### Summary

Handler called when [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette') instance create a new
    [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| widget | [WidgetBoardControl.Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') | Created [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') instance |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnGridColumnCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnGridColumnCountChanged(d,e) `method`

##### Summary

Handler called when the [GridColumnCount](#P-WidgetBoardControl-Views-WidgetBoard-GridColumnCount 'WidgetBoardControl.Views.WidgetBoard.GridColumnCount') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnGridRowCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnGridRowCountChanged(d,e) `method`

##### Summary

Handler called when the [GridRowCount](#P-WidgetBoardControl-Views-WidgetBoard-GridRowCount 'WidgetBoardControl.Views.WidgetBoard.GridRowCount') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnIsGridDisplayedChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsGridDisplayedChanged(d,e) `method`

##### Summary

Handler called when the [IsGridDisplayed](#P-WidgetBoardControl-Views-WidgetBoard-IsGridDisplayed 'WidgetBoardControl.Views.WidgetBoard.IsGridDisplayed') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnIsManipulatorHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsManipulatorHiddenChanged(d,e) `method`

##### Summary

Handler called when the [IsManipulatorHidden](#P-WidgetBoardControl-Views-WidgetBoard-IsManipulatorHidden 'WidgetBoardControl.Views.WidgetBoard.IsManipulatorHidden') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnIsSidebarHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsSidebarHiddenChanged(d,e) `method`

##### Summary

Handler called when the [IsSidebarHidden](#P-WidgetBoardControl-Views-WidgetBoard-IsSidebarHidden 'WidgetBoardControl.Views.WidgetBoard.IsSidebarHidden') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnLoad-System-Object,System-Windows-RoutedEventArgs-'></a>
### OnLoad(sender) `method`

##### Summary

Handler called when the [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') has been completely initialized

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance that has been initialized |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnPaletteBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnPaletteBackgroundChanged(d,e) `method`

##### Summary

Handler called when the [PaletteBackground](#P-WidgetBoardControl-Views-WidgetBoard-PaletteBackground 'WidgetBoardControl.Views.WidgetBoard.PaletteBackground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnPaletteChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs-'></a>
### OnPaletteChangedHandler(sender,e) `method`

##### Summary

Handler called when the [WidgetsPalette](#P-WidgetBoardControl-Views-WidgetBoard-WidgetsPalette 'WidgetBoardControl.Views.WidgetBoard.WidgetsPalette') collection changed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.Collections.Specialized.NotifyCollectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.NotifyCollectionChangedEventArgs 'System.Collections.Specialized.NotifyCollectionChangedEventArgs') | An object that describes a change in a collection |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnPaletteForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnPaletteForegroundChanged(d,e) `method`

##### Summary

Handler called when the [PaletteForeground](#P-WidgetBoardControl-Views-WidgetBoard-PaletteForeground 'WidgetBoardControl.Views.WidgetBoard.PaletteForeground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs-'></a>
### OnSizeChanged(sender,e) `method`

##### Summary

Handler called when the [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') has been resized

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.SizeChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.SizeChangedEventArgs 'System.Windows.SizeChangedEventArgs') | An object that describes a size changing |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnWidgetsOnBoardChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnWidgetsOnBoardChanged(d,e) `method`

##### Summary

Handler called when the [WidgetsOnBoard](#P-WidgetBoardControl-Views-WidgetBoard-WidgetsOnBoard 'WidgetBoardControl.Views.WidgetBoard.WidgetsOnBoard') replaced

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnWidgetsPaletteChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnWidgetsPaletteChanged(d,e) `method`

##### Summary

Handler called when the [WidgetPalette](#F-WidgetBoardControl-Views-WidgetBoard-WidgetPalette 'WidgetBoardControl.Views.WidgetBoard.WidgetPalette') replaced

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-WidgetBoardControl-Views-WidgetBoard-OnWidthAnimationCompletedHandler-System-Object,System-EventArgs-'></a>
### OnWidthAnimationCompletedHandler(sender,e) `method`

##### Summary

Handler called then transform animation is completed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event arguments (empty) |

<a name='M-WidgetBoardControl-Views-WidgetBoard-RemoveWidget-WidgetBoardControl-Widget-'></a>
### RemoveWidget(widget) `method`

##### Summary

Remove [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') from WidgetBoard

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widget | [WidgetBoardControl.Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') | Removed [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') instance |

<a name='M-WidgetBoardControl-Views-WidgetBoard-RenderWidgetPalette'></a>
### RenderWidgetPalette() `method`

##### Summary

Draw a widget palettes in sidebar

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-ResizeGrid'></a>
### ResizeGrid() `method`

##### Summary

Update the positions of the background grid lines

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-ToggleAutoCellSize'></a>
### ToggleAutoCellSize() `method`

##### Summary

Update cell size by [AutoCellSize](#P-WidgetBoardControl-Views-WidgetBoard-AutoCellSize 'WidgetBoardControl.Views.WidgetBoard.AutoCellSize') value

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-ToggleWidgetManipulators'></a>
### ToggleWidgetManipulators() `method`

##### Summary

Toggles visibility of [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') Manipulators

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-ToggleWidgetSidebar'></a>
### ToggleWidgetSidebar() `method`

##### Summary

Toggles visibility of sidebar with [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette')

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-Views-WidgetBoard-UpdateGridDimensions'></a>
### UpdateGridDimensions() `method`

##### Summary

Complete updating grid lines

##### Parameters

This method has no parameters.

<a name='T-WidgetBoardControl-Views-WidgetPalette'></a>
## WidgetPalette `type`

##### Namespace

WidgetBoardControl.Views

##### Summary

Логика взаимодействия для WidgetPalette.xaml

<a name='T-WidgetBoardControl-WidgetPalette'></a>
## WidgetPalette `type`

##### Namespace

WidgetBoardControl

##### Summary

Represents a view model for [WidgetPalette](#T-WidgetBoardControl-Views-WidgetPalette 'WidgetBoardControl.Views.WidgetPalette') that provide instantiating
    [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') on a [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard').

<a name='M-WidgetBoardControl-Views-WidgetPalette-#ctor'></a>
### #ctor() `constructor`

##### Summary

Represents a UI element that allows [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') of the specified type to
    be created on a [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard').

##### Parameters

This constructor has no parameters.

<a name='M-WidgetBoardControl-WidgetPalette-#ctor-System-Type,System-Type,System-Type-'></a>
### #ctor(widgetType,widgetControlType,widgetViewModelType) `constructor`

##### Summary

Class that provides the ability to create widgets on a
    [WidgetBoard](#T-WidgetBoardControl-Views-WidgetBoard 'WidgetBoardControl.Views.WidgetBoard').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widgetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of child class that should inherit
    [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') class. |
| widgetControlType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type that should inherit [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') and that will be
    embedded in the Widget. |
| widgetViewModelType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Occurs when types are passed as arguments that do not inherit the required classes. |

<a name='P-WidgetBoardControl-WidgetPalette-CreateWidgetCommand'></a>
### CreateWidgetCommand `property`

##### Summary

Command that triggered [](#E-WidgetBoardControl-WidgetPalette-OnCreateWidgetEvent 'WidgetBoardControl.WidgetPalette.OnCreateWidgetEvent')

<a name='P-WidgetBoardControl-WidgetPalette-GroupName'></a>
### GroupName `property`

##### Summary

Gets or sets the name for grouping widgets in the palette

<a name='P-WidgetBoardControl-WidgetPalette-IconBase64'></a>
### IconBase64 `property`

##### Summary

Gets the Icon in Base64 format

<a name='P-WidgetBoardControl-WidgetPalette-IconBytes'></a>
### IconBytes `property`

##### Summary

Gets or sets the ByteArray of SVG file for drawing the icon

<a name='P-WidgetBoardControl-WidgetPalette-Title'></a>
### Title `property`

##### Summary

Gets or sets the title displayed in the interface of the [WidgetPalette](#T-WidgetBoardControl-WidgetPalette 'WidgetBoardControl.WidgetPalette')

<a name='P-WidgetBoardControl-WidgetPalette-WidgetId'></a>
### WidgetId `property`

##### Summary

Gets or protected sets the widget variant ID

<a name='P-WidgetBoardControl-WidgetPalette-WidgetPaletteView'></a>
### WidgetPaletteView `property`

##### Summary

Gets the view for WidgetPalette Control

<a name='M-WidgetBoardControl-Views-WidgetPalette-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-WidgetPalette-CreateWidgetInstance'></a>
### CreateWidgetInstance() `method`

##### Summary

Creates a widget based on the types specified in the constructor.

##### Returns

Created [Widget](#T-WidgetBoardControl-Widget 'WidgetBoardControl.Widget') instance

##### Parameters

This method has no parameters.

<a name='M-WidgetBoardControl-WidgetPalette-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(prop) `method`

##### Summary

Method that do trigger [](#E-WidgetBoardControl-WidgetPalette-PropertyChanged 'WidgetBoardControl.WidgetPalette.PropertyChanged')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prop | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |
