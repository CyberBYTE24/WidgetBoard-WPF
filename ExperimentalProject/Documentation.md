<a name='assembly'></a>
# ExperimentalProject

## Contents

- [ActionsWidgetHandler](#T-ExperimentalProject-Widget-ActionsWidgetHandler 'ExperimentalProject.Widget.ActionsWidgetHandler')
- [IUserWidgetViewModel](#T-ExperimentalProject-IUserWidgetViewModel 'ExperimentalProject.IUserWidgetViewModel')
  - [Settings](#P-ExperimentalProject-IUserWidgetViewModel-Settings 'ExperimentalProject.IUserWidgetViewModel.Settings')
- [OnCreateWidget](#T-ExperimentalProject-WidgetPalette-OnCreateWidget 'ExperimentalProject.WidgetPalette.OnCreateWidget')
- [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget')
- [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget')
  - [#ctor(userControl)](#M-ExperimentalProject-Views-Widget-#ctor-System-Windows-Controls-UserControl- 'ExperimentalProject.Views.Widget.#ctor(System.Windows.Controls.UserControl)')
  - [#ctor(widgetControl,widgetViewModel,widgetId)](#M-ExperimentalProject-Widget-#ctor-System-Windows-Controls-UserControl,System-Object,System-Guid- 'ExperimentalProject.Widget.#ctor(System.Windows.Controls.UserControl,System.Object,System.Guid)')
  - [Column](#P-ExperimentalProject-Views-Widget-Column 'ExperimentalProject.Views.Widget.Column')
  - [ColumnSpan](#P-ExperimentalProject-Views-Widget-ColumnSpan 'ExperimentalProject.Views.Widget.ColumnSpan')
  - [ManipulatorVisibility](#P-ExperimentalProject-Views-Widget-ManipulatorVisibility 'ExperimentalProject.Views.Widget.ManipulatorVisibility')
  - [MinColumnSpan](#P-ExperimentalProject-Views-Widget-MinColumnSpan 'ExperimentalProject.Views.Widget.MinColumnSpan')
  - [MinRowSpan](#P-ExperimentalProject-Views-Widget-MinRowSpan 'ExperimentalProject.Views.Widget.MinRowSpan')
  - [Row](#P-ExperimentalProject-Views-Widget-Row 'ExperimentalProject.Views.Widget.Row')
  - [RowSpan](#P-ExperimentalProject-Views-Widget-RowSpan 'ExperimentalProject.Views.Widget.RowSpan')
  - [SettingsButtonVisibility](#P-ExperimentalProject-Views-Widget-SettingsButtonVisibility 'ExperimentalProject.Views.Widget.SettingsButtonVisibility')
  - [ShadowOpacity](#P-ExperimentalProject-Views-Widget-ShadowOpacity 'ExperimentalProject.Views.Widget.ShadowOpacity')
  - [Column](#P-ExperimentalProject-Widget-Column 'ExperimentalProject.Widget.Column')
  - [ColumnSpan](#P-ExperimentalProject-Widget-ColumnSpan 'ExperimentalProject.Widget.ColumnSpan')
  - [IsManipulatorVisible](#P-ExperimentalProject-Widget-IsManipulatorVisible 'ExperimentalProject.Widget.IsManipulatorVisible')
  - [IsSettingsButtonVisible](#P-ExperimentalProject-Widget-IsSettingsButtonVisible 'ExperimentalProject.Widget.IsSettingsButtonVisible')
  - [MinColumnSpan](#P-ExperimentalProject-Widget-MinColumnSpan 'ExperimentalProject.Widget.MinColumnSpan')
  - [MinRowSpan](#P-ExperimentalProject-Widget-MinRowSpan 'ExperimentalProject.Widget.MinRowSpan')
  - [RemoveCommand](#P-ExperimentalProject-Widget-RemoveCommand 'ExperimentalProject.Widget.RemoveCommand')
  - [Row](#P-ExperimentalProject-Widget-Row 'ExperimentalProject.Widget.Row')
  - [RowSpan](#P-ExperimentalProject-Widget-RowSpan 'ExperimentalProject.Widget.RowSpan')
  - [Settings](#P-ExperimentalProject-Widget-Settings 'ExperimentalProject.Widget.Settings')
  - [SettingsCommand](#P-ExperimentalProject-Widget-SettingsCommand 'ExperimentalProject.Widget.SettingsCommand')
  - [ShadowOpacity](#P-ExperimentalProject-Widget-ShadowOpacity 'ExperimentalProject.Widget.ShadowOpacity')
  - [Title](#P-ExperimentalProject-Widget-Title 'ExperimentalProject.Widget.Title')
  - [WidgetId](#P-ExperimentalProject-Widget-WidgetId 'ExperimentalProject.Widget.WidgetId')
  - [WidgetView](#P-ExperimentalProject-Widget-WidgetView 'ExperimentalProject.Widget.WidgetView')
  - [#cctor()](#M-ExperimentalProject-Views-Widget-#cctor 'ExperimentalProject.Views.Widget.#cctor')
  - [HeaderMouseLeftButtonDownHandler(sender,e)](#M-ExperimentalProject-Views-Widget-HeaderMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'ExperimentalProject.Views.Widget.HeaderMouseLeftButtonDownHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [HeaderMouseLeftButtonUpHandler(sender,e)](#M-ExperimentalProject-Views-Widget-HeaderMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'ExperimentalProject.Views.Widget.HeaderMouseLeftButtonUpHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [HeaderMouseMoveHandler(sender,e)](#M-ExperimentalProject-Views-Widget-HeaderMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs- 'ExperimentalProject.Views.Widget.HeaderMouseMoveHandler(System.Object,System.Windows.Input.MouseEventArgs)')
  - [HeightAnimation_Completed(sender,e)](#M-ExperimentalProject-Views-Widget-HeightAnimation_Completed-System-Object,System-EventArgs- 'ExperimentalProject.Views.Widget.HeightAnimation_Completed(System.Object,System.EventArgs)')
  - [InitializeComponent()](#M-ExperimentalProject-Views-Widget-InitializeComponent 'ExperimentalProject.Views.Widget.InitializeComponent')
  - [InitializeOnBoard()](#M-ExperimentalProject-Views-Widget-InitializeOnBoard 'ExperimentalProject.Views.Widget.InitializeOnBoard')
  - [LeftAnimation_Completed(sender,e)](#M-ExperimentalProject-Views-Widget-LeftAnimation_Completed-System-Object,System-EventArgs- 'ExperimentalProject.Views.Widget.LeftAnimation_Completed(System.Object,System.EventArgs)')
  - [OnColumnChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnColumnChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnColumnChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnColumnSpanChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnColumnSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnManipulatorVisibilityChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnManipulatorVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnManipulatorVisibilityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnMinColumnSpanChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnMinColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnMinColumnSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnMinRowSpanChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnMinRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnMinRowSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnRowChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnRowChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnRowChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnRowSpanChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnRowSpanChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnSettingsButtonVisibilityChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnSettingsButtonVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnSettingsButtonVisibilityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnShadowOpacityChanged(d,e)](#M-ExperimentalProject-Views-Widget-OnShadowOpacityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.Widget.OnShadowOpacityChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [ResizeMouseLeftButtonDownHandler(sender,e)](#M-ExperimentalProject-Views-Widget-ResizeMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'ExperimentalProject.Views.Widget.ResizeMouseLeftButtonDownHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [ResizeMouseLeftButtonUpHandler(sender,e)](#M-ExperimentalProject-Views-Widget-ResizeMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs- 'ExperimentalProject.Views.Widget.ResizeMouseLeftButtonUpHandler(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [ResizeMouseMoveHandler(sender,e)](#M-ExperimentalProject-Views-Widget-ResizeMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs- 'ExperimentalProject.Views.Widget.ResizeMouseMoveHandler(System.Object,System.Windows.Input.MouseEventArgs)')
  - [SetCellHeight(value)](#M-ExperimentalProject-Views-Widget-SetCellHeight-System-Double- 'ExperimentalProject.Views.Widget.SetCellHeight(System.Double)')
  - [SetCellWidth(value)](#M-ExperimentalProject-Views-Widget-SetCellWidth-System-Double- 'ExperimentalProject.Views.Widget.SetCellWidth(System.Double)')
  - [TopAnimation_Completed(sender,e)](#M-ExperimentalProject-Views-Widget-TopAnimation_Completed-System-Object,System-EventArgs- 'ExperimentalProject.Views.Widget.TopAnimation_Completed(System.Object,System.EventArgs)')
  - [WidthAnimation_Completed(sender,e)](#M-ExperimentalProject-Views-Widget-WidthAnimation_Completed-System-Object,System-EventArgs- 'ExperimentalProject.Views.Widget.WidthAnimation_Completed(System.Object,System.EventArgs)')
  - [OnPropertyChanged(prop)](#M-ExperimentalProject-Widget-OnPropertyChanged-System-String- 'ExperimentalProject.Widget.OnPropertyChanged(System.String)')
  - [SetCellHeight(value)](#M-ExperimentalProject-Widget-SetCellHeight-System-Double- 'ExperimentalProject.Widget.SetCellHeight(System.Double)')
  - [SetCellWidth(value)](#M-ExperimentalProject-Widget-SetCellWidth-System-Double- 'ExperimentalProject.Widget.SetCellWidth(System.Double)')
- [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard')
  - [#ctor()](#M-ExperimentalProject-Views-WidgetBoard-#ctor 'ExperimentalProject.Views.WidgetBoard.#ctor')
  - [AutoCellSize](#P-ExperimentalProject-Views-WidgetBoard-AutoCellSize 'ExperimentalProject.Views.WidgetBoard.AutoCellSize')
  - [BoardBackground](#P-ExperimentalProject-Views-WidgetBoard-BoardBackground 'ExperimentalProject.Views.WidgetBoard.BoardBackground')
  - [BoardForeground](#P-ExperimentalProject-Views-WidgetBoard-BoardForeground 'ExperimentalProject.Views.WidgetBoard.BoardForeground')
  - [CellHeight](#P-ExperimentalProject-Views-WidgetBoard-CellHeight 'ExperimentalProject.Views.WidgetBoard.CellHeight')
  - [CellWidth](#P-ExperimentalProject-Views-WidgetBoard-CellWidth 'ExperimentalProject.Views.WidgetBoard.CellWidth')
  - [GridColumnCount](#P-ExperimentalProject-Views-WidgetBoard-GridColumnCount 'ExperimentalProject.Views.WidgetBoard.GridColumnCount')
  - [GridRowCount](#P-ExperimentalProject-Views-WidgetBoard-GridRowCount 'ExperimentalProject.Views.WidgetBoard.GridRowCount')
  - [IsGridDisplayed](#P-ExperimentalProject-Views-WidgetBoard-IsGridDisplayed 'ExperimentalProject.Views.WidgetBoard.IsGridDisplayed')
  - [IsManipulatorHidden](#P-ExperimentalProject-Views-WidgetBoard-IsManipulatorHidden 'ExperimentalProject.Views.WidgetBoard.IsManipulatorHidden')
  - [IsSidebarHidden](#P-ExperimentalProject-Views-WidgetBoard-IsSidebarHidden 'ExperimentalProject.Views.WidgetBoard.IsSidebarHidden')
  - [PaletteBackground](#P-ExperimentalProject-Views-WidgetBoard-PaletteBackground 'ExperimentalProject.Views.WidgetBoard.PaletteBackground')
  - [PaletteForeground](#P-ExperimentalProject-Views-WidgetBoard-PaletteForeground 'ExperimentalProject.Views.WidgetBoard.PaletteForeground')
  - [SidebarWidth](#P-ExperimentalProject-Views-WidgetBoard-SidebarWidth 'ExperimentalProject.Views.WidgetBoard.SidebarWidth')
  - [WidgetsOnBoard](#P-ExperimentalProject-Views-WidgetBoard-WidgetsOnBoard 'ExperimentalProject.Views.WidgetBoard.WidgetsOnBoard')
  - [WidgetsPalette](#P-ExperimentalProject-Views-WidgetBoard-WidgetsPalette 'ExperimentalProject.Views.WidgetBoard.WidgetsPalette')
  - [#cctor()](#M-ExperimentalProject-Views-WidgetBoard-#cctor 'ExperimentalProject.Views.WidgetBoard.#cctor')
  - [AddWidget(widget)](#M-ExperimentalProject-Views-WidgetBoard-AddWidget-ExperimentalProject-Widget- 'ExperimentalProject.Views.WidgetBoard.AddWidget(ExperimentalProject.Widget)')
  - [InitializeComponent()](#M-ExperimentalProject-Views-WidgetBoard-InitializeComponent 'ExperimentalProject.Views.WidgetBoard.InitializeComponent')
  - [OnAutoCellSizeChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnAutoCellSizeChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnAutoCellSizeChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnBoardBackgroundChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnBoardBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnBoardBackgroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnBoardChangedHandler(sender,e)](#M-ExperimentalProject-Views-WidgetBoard-OnBoardChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnBoardChangedHandler(System.Object,System.Collections.Specialized.NotifyCollectionChangedEventArgs)')
  - [OnBoardForegroundChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnBoardForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnBoardForegroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCellHeightChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnCellHeightChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnCellHeightChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCellWidthChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnCellWidthChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnCellWidthChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnCreateWidgetHandler(sender,widget)](#M-ExperimentalProject-Views-WidgetBoard-OnCreateWidgetHandler-System-Object,ExperimentalProject-Widget- 'ExperimentalProject.Views.WidgetBoard.OnCreateWidgetHandler(System.Object,ExperimentalProject.Widget)')
  - [OnGridColumnCountChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnGridColumnCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnGridColumnCountChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnGridRowCountChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnGridRowCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnGridRowCountChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsGridDisplayedChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnIsGridDisplayedChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnIsGridDisplayedChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsManipulatorHiddenChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnIsManipulatorHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnIsManipulatorHiddenChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnIsSidebarHiddenChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnIsSidebarHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnIsSidebarHiddenChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnLoad(sender)](#M-ExperimentalProject-Views-WidgetBoard-OnLoad-System-Object,System-Windows-RoutedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnLoad(System.Object,System.Windows.RoutedEventArgs)')
  - [OnPaletteBackgroundChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnPaletteBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnPaletteBackgroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnPaletteChangedHandler(sender,e)](#M-ExperimentalProject-Views-WidgetBoard-OnPaletteChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnPaletteChangedHandler(System.Object,System.Collections.Specialized.NotifyCollectionChangedEventArgs)')
  - [OnPaletteForegroundChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnPaletteForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnPaletteForegroundChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnSizeChanged(sender,e)](#M-ExperimentalProject-Views-WidgetBoard-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnSizeChanged(System.Object,System.Windows.SizeChangedEventArgs)')
  - [OnWidgetsOnBoardChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnWidgetsOnBoardChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnWidgetsOnBoardChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnWidgetsPaletteChanged(d,e)](#M-ExperimentalProject-Views-WidgetBoard-OnWidgetsPaletteChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'ExperimentalProject.Views.WidgetBoard.OnWidgetsPaletteChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [OnWidthAnimationCompletedHandler(sender,e)](#M-ExperimentalProject-Views-WidgetBoard-OnWidthAnimationCompletedHandler-System-Object,System-EventArgs- 'ExperimentalProject.Views.WidgetBoard.OnWidthAnimationCompletedHandler(System.Object,System.EventArgs)')
  - [RemoveWidget(widget)](#M-ExperimentalProject-Views-WidgetBoard-RemoveWidget-ExperimentalProject-Widget- 'ExperimentalProject.Views.WidgetBoard.RemoveWidget(ExperimentalProject.Widget)')
  - [RenderWidgetPalette()](#M-ExperimentalProject-Views-WidgetBoard-RenderWidgetPalette 'ExperimentalProject.Views.WidgetBoard.RenderWidgetPalette')
  - [ResizeGrid()](#M-ExperimentalProject-Views-WidgetBoard-ResizeGrid 'ExperimentalProject.Views.WidgetBoard.ResizeGrid')
  - [ToggleAutoCellSize()](#M-ExperimentalProject-Views-WidgetBoard-ToggleAutoCellSize 'ExperimentalProject.Views.WidgetBoard.ToggleAutoCellSize')
  - [ToggleWidgetManipulators()](#M-ExperimentalProject-Views-WidgetBoard-ToggleWidgetManipulators 'ExperimentalProject.Views.WidgetBoard.ToggleWidgetManipulators')
  - [ToggleWidgetSidebar()](#M-ExperimentalProject-Views-WidgetBoard-ToggleWidgetSidebar 'ExperimentalProject.Views.WidgetBoard.ToggleWidgetSidebar')
  - [UpdateGridDimensions()](#M-ExperimentalProject-Views-WidgetBoard-UpdateGridDimensions 'ExperimentalProject.Views.WidgetBoard.UpdateGridDimensions')
- [WidgetPalette](#T-ExperimentalProject-Views-WidgetPalette 'ExperimentalProject.Views.WidgetPalette')
- [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette')
  - [#ctor()](#M-ExperimentalProject-Views-WidgetPalette-#ctor 'ExperimentalProject.Views.WidgetPalette.#ctor')
  - [#ctor(widgetType,widgetControlType,widgetViewModelType)](#M-ExperimentalProject-WidgetPalette-#ctor-System-Type,System-Type,System-Type- 'ExperimentalProject.WidgetPalette.#ctor(System.Type,System.Type,System.Type)')
  - [CreateWidgetCommand](#P-ExperimentalProject-WidgetPalette-CreateWidgetCommand 'ExperimentalProject.WidgetPalette.CreateWidgetCommand')
  - [GroupName](#P-ExperimentalProject-WidgetPalette-GroupName 'ExperimentalProject.WidgetPalette.GroupName')
  - [IconBase64](#P-ExperimentalProject-WidgetPalette-IconBase64 'ExperimentalProject.WidgetPalette.IconBase64')
  - [IconBytes](#P-ExperimentalProject-WidgetPalette-IconBytes 'ExperimentalProject.WidgetPalette.IconBytes')
  - [Title](#P-ExperimentalProject-WidgetPalette-Title 'ExperimentalProject.WidgetPalette.Title')
  - [WidgetId](#P-ExperimentalProject-WidgetPalette-WidgetId 'ExperimentalProject.WidgetPalette.WidgetId')
  - [WidgetPaletteView](#P-ExperimentalProject-WidgetPalette-WidgetPaletteView 'ExperimentalProject.WidgetPalette.WidgetPaletteView')
  - [InitializeComponent()](#M-ExperimentalProject-Views-WidgetPalette-InitializeComponent 'ExperimentalProject.Views.WidgetPalette.InitializeComponent')
  - [CreateWidgetInstance()](#M-ExperimentalProject-WidgetPalette-CreateWidgetInstance 'ExperimentalProject.WidgetPalette.CreateWidgetInstance')
  - [OnPropertyChanged(prop)](#M-ExperimentalProject-WidgetPalette-OnPropertyChanged-System-String- 'ExperimentalProject.WidgetPalette.OnPropertyChanged(System.String)')

<a name='T-ExperimentalProject-Widget-ActionsWidgetHandler'></a>
## ActionsWidgetHandler `type`

##### Namespace

ExperimentalProject.Widget

##### Summary

Describes the signature of an event handler that fires when an action occurs on a widget.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:ExperimentalProject.Widget.ActionsWidgetHandler](#T-T-ExperimentalProject-Widget-ActionsWidgetHandler 'T:ExperimentalProject.Widget.ActionsWidgetHandler') | Widget on which the action takes place |

<a name='T-ExperimentalProject-IUserWidgetViewModel'></a>
## IUserWidgetViewModel `type`

##### Namespace

ExperimentalProject

##### Summary

Declares properties for working with widget settings

<a name='P-ExperimentalProject-IUserWidgetViewModel-Settings'></a>
### Settings `property`

##### Summary

Gets or sets the settings of widget

<a name='T-ExperimentalProject-WidgetPalette-OnCreateWidget'></a>
## OnCreateWidget `type`

##### Namespace

ExperimentalProject.WidgetPalette

##### Summary

Describes the signature of event handlers that fire when [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') are created.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:ExperimentalProject.WidgetPalette.OnCreateWidget](#T-T-ExperimentalProject-WidgetPalette-OnCreateWidget 'T:ExperimentalProject.WidgetPalette.OnCreateWidget') | The object that triggered the event |

<a name='T-ExperimentalProject-Views-Widget'></a>
## Widget `type`

##### Namespace

ExperimentalProject.Views

##### Summary

Represents a Widget item on a [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard').

<a name='T-ExperimentalProject-Widget'></a>
## Widget `type`

##### Namespace

ExperimentalProject

##### Summary

Represents a view model for [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') that can be placed on a
    [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard').

<a name='M-ExperimentalProject-Views-Widget-#ctor-System-Windows-Controls-UserControl-'></a>
### #ctor(userControl) `constructor`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userControl | [System.Windows.Controls.UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') |  |

<a name='M-ExperimentalProject-Widget-#ctor-System-Windows-Controls-UserControl,System-Object,System-Guid-'></a>
### #ctor(widgetControl,widgetViewModel,widgetId) `constructor`

##### Summary

Class that represents the view model of a [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') on a widget board.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widgetControl | [System.Windows.Controls.UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') | [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') to be included in the widget |
| widgetViewModel | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | ViewModel object for WidgetControl |
| widgetId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | Widget type ID |

<a name='P-ExperimentalProject-Views-Widget-Column'></a>
### Column `property`

##### Summary

Gets or sets the X-position on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-ColumnSpan'></a>
### ColumnSpan `property`

##### Summary

Gets or sets the width on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-ManipulatorVisibility'></a>
### ManipulatorVisibility `property`

##### Summary

Gets or sets the visibility state of Widget manipulator

<a name='P-ExperimentalProject-Views-Widget-MinColumnSpan'></a>
### MinColumnSpan `property`

##### Summary

Gets or sets the minimal Widget width (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-MinRowSpan'></a>
### MinRowSpan `property`

##### Summary

Gets or sets the minimal Widget height (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-Row'></a>
### Row `property`

##### Summary

Gets or sets the Y-position on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-RowSpan'></a>
### RowSpan `property`

##### Summary

Gets or sets the height on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Views-Widget-SettingsButtonVisibility'></a>
### SettingsButtonVisibility `property`

##### Summary

Gets or sets the visibility of the settings button

<a name='P-ExperimentalProject-Views-Widget-ShadowOpacity'></a>
### ShadowOpacity `property`

##### Summary

The transparency of the shadow cast by the widget

<a name='P-ExperimentalProject-Widget-Column'></a>
### Column `property`

##### Summary

Gets or sets the X-position on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Widget-ColumnSpan'></a>
### ColumnSpan `property`

##### Summary

Gets or sets the width on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Widget-IsManipulatorVisible'></a>
### IsManipulatorVisible `property`

##### Summary

Gets or sets the flag representing the visibility state of controls

<a name='P-ExperimentalProject-Widget-IsSettingsButtonVisible'></a>
### IsSettingsButtonVisible `property`

##### Summary

Gets or sets the flag representing the visibility state of Settings Button in header

<a name='P-ExperimentalProject-Widget-MinColumnSpan'></a>
### MinColumnSpan `property`

##### Summary

Gets or sets the minimal Widget width (measured in cells)

<a name='P-ExperimentalProject-Widget-MinRowSpan'></a>
### MinRowSpan `property`

##### Summary

Gets or sets the minimal Widget height (measured in cells)

<a name='P-ExperimentalProject-Widget-RemoveCommand'></a>
### RemoveCommand `property`

##### Summary

Command that triggered [](#E-ExperimentalProject-Widget-OnRemoveWidgetEvent 'ExperimentalProject.Widget.OnRemoveWidgetEvent')

<a name='P-ExperimentalProject-Widget-Row'></a>
### Row `property`

##### Summary

Gets or sets the widget height on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Widget-RowSpan'></a>
### RowSpan `property`

##### Summary

Gets or sets the height on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') (measured in cells)

<a name='P-ExperimentalProject-Widget-Settings'></a>
### Settings `property`

##### Summary

Gets or sets the custom settings for saving state in serialized data

<a name='P-ExperimentalProject-Widget-SettingsCommand'></a>
### SettingsCommand `property`

##### Summary

Command that triggered [](#E-ExperimentalProject-Widget-OnSettingsWidgetEvent 'ExperimentalProject.Widget.OnSettingsWidgetEvent')

<a name='P-ExperimentalProject-Widget-ShadowOpacity'></a>
### ShadowOpacity `property`

##### Summary

Gets or sets the transparency value of the shadow cast by the widget

<a name='P-ExperimentalProject-Widget-Title'></a>
### Title `property`

##### Summary

Gets or sets the title displayed in the interface of the [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget')

<a name='P-ExperimentalProject-Widget-WidgetId'></a>
### WidgetId `property`

##### Summary

Gets or protected sets the widget variant ID

<a name='P-ExperimentalProject-Widget-WidgetView'></a>
### WidgetView `property`

##### Summary

Completed widget presentation for placement on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard')

<a name='M-ExperimentalProject-Views-Widget-#cctor'></a>
### #cctor() `method`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-Widget-HeaderMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### HeaderMouseLeftButtonDownHandler(sender,e) `method`

##### Summary

Handler called when Widget Drag start

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-ExperimentalProject-Views-Widget-HeaderMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### HeaderMouseLeftButtonUpHandler(sender,e) `method`

##### Summary

Handler called when Widget Drag end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-ExperimentalProject-Views-Widget-HeaderMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs-'></a>
### HeaderMouseMoveHandler(sender,e) `method`

##### Summary

Handler called during Widget Drag

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseEventArgs 'System.Windows.Input.MouseEventArgs') | Provides data for mouse position events |

<a name='M-ExperimentalProject-Views-Widget-HeightAnimation_Completed-System-Object,System-EventArgs-'></a>
### HeightAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Height animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-ExperimentalProject-Views-Widget-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-Widget-InitializeOnBoard'></a>
### InitializeOnBoard() `method`

##### Summary

Update Widget transformation on [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard')

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-Widget-LeftAnimation_Completed-System-Object,System-EventArgs-'></a>
### LeftAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the X-position animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-ExperimentalProject-Views-Widget-OnColumnChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnColumnChanged(d,e) `method`

##### Summary

Handler called when the Column changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnColumnSpanChanged(d,e) `method`

##### Summary

Handler called when the ColumnSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnManipulatorVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnManipulatorVisibilityChanged(d,e) `method`

##### Summary

Handler called when the Manipulator Visibility changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnMinColumnSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnMinColumnSpanChanged(d,e) `method`

##### Summary

Handler called when the Minimal ColumnSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnMinRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnMinRowSpanChanged(d,e) `method`

##### Summary

Handler called when the Minimal RowSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnRowChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnRowChanged(d,e) `method`

##### Summary

Handler called when the Row changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnRowSpanChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnRowSpanChanged(d,e) `method`

##### Summary

Handler called when the RowSpan changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnSettingsButtonVisibilityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnSettingsButtonVisibilityChanged(d,e) `method`

##### Summary

Handler that is called when the visibility state changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-OnShadowOpacityChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnShadowOpacityChanged(d,e) `method`

##### Summary

Handler that is called when the shadow opacity changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-Widget-ResizeMouseLeftButtonDownHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ResizeMouseLeftButtonDownHandler(sender,e) `method`

##### Summary

Handler called when Widget Resize start

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-ExperimentalProject-Views-Widget-ResizeMouseLeftButtonUpHandler-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ResizeMouseLeftButtonUpHandler(sender,e) `method`

##### Summary

Handler called when Widget Resize end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | Provides data for mouse button events |

<a name='M-ExperimentalProject-Views-Widget-ResizeMouseMoveHandler-System-Object,System-Windows-Input-MouseEventArgs-'></a>
### ResizeMouseMoveHandler(sender,e) `method`

##### Summary

Handler called during Widget Resize

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.Windows.Input.MouseEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseEventArgs 'System.Windows.Input.MouseEventArgs') | Provides data for mouse position events |

<a name='M-ExperimentalProject-Views-Widget-SetCellHeight-System-Double-'></a>
### SetCellHeight(value) `method`

##### Summary

Set new cell height and then update transform

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New cell height |

<a name='M-ExperimentalProject-Views-Widget-SetCellWidth-System-Double-'></a>
### SetCellWidth(value) `method`

##### Summary

Set new cell width and then update transform

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New cell width |

<a name='M-ExperimentalProject-Views-Widget-TopAnimation_Completed-System-Object,System-EventArgs-'></a>
### TopAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Y-position animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-ExperimentalProject-Views-Widget-WidthAnimation_Completed-System-Object,System-EventArgs-'></a>
### WidthAnimation_Completed(sender,e) `method`

##### Summary

Handler called when the Width animation end

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that triggered the event |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event argument object (empty) |

<a name='M-ExperimentalProject-Widget-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(prop) `method`

##### Summary

Method that do trigger [](#E-ExperimentalProject-Widget-PropertyChanged 'ExperimentalProject.Widget.PropertyChanged')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prop | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |

<a name='M-ExperimentalProject-Widget-SetCellHeight-System-Double-'></a>
### SetCellHeight(value) `method`

##### Summary

Sets the cell height to use in building the interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Cell height size |

<a name='M-ExperimentalProject-Widget-SetCellWidth-System-Double-'></a>
### SetCellWidth(value) `method`

##### Summary

Sets the cell width to use in building the interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Cell width size |

<a name='T-ExperimentalProject-Views-WidgetBoard'></a>
## WidgetBoard `type`

##### Namespace

ExperimentalProject.Views

##### Summary

Represent element for placing [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') and
    [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette')

<a name='M-ExperimentalProject-Views-WidgetBoard-#ctor'></a>
### #ctor() `constructor`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This constructor has no parameters.

<a name='P-ExperimentalProject-Views-WidgetBoard-AutoCellSize'></a>
### AutoCellSize `property`

##### Summary

Gets or sets the activity of calculated cell sizes

<a name='P-ExperimentalProject-Views-WidgetBoard-BoardBackground'></a>
### BoardBackground `property`

##### Summary

Gets or sets the filling the background for the main widget board field

<a name='P-ExperimentalProject-Views-WidgetBoard-BoardForeground'></a>
### BoardForeground `property`

##### Summary

Gets or sets the color for grid lines and other stuff

<a name='P-ExperimentalProject-Views-WidgetBoard-CellHeight'></a>
### CellHeight `property`

##### Summary

Gets or sets the cell height to use in building the interface.

<a name='P-ExperimentalProject-Views-WidgetBoard-CellWidth'></a>
### CellWidth `property`

##### Summary

Gets or sets the cell width to use in building the interface.

<a name='P-ExperimentalProject-Views-WidgetBoard-GridColumnCount'></a>
### GridColumnCount `property`

##### Summary

Gets or sets the displayed on background grid column count

<a name='P-ExperimentalProject-Views-WidgetBoard-GridRowCount'></a>
### GridRowCount `property`

##### Summary

Gets or sets the displayed on background grid row count

<a name='P-ExperimentalProject-Views-WidgetBoard-IsGridDisplayed'></a>
### IsGridDisplayed `property`

##### Summary

Gets or sets the grid's rendering state

<a name='P-ExperimentalProject-Views-WidgetBoard-IsManipulatorHidden'></a>
### IsManipulatorHidden `property`

##### Summary

Gets or sets the visibility of widget manipulators for [Widget](#T-ExperimentalProject-Views-Widget 'ExperimentalProject.Views.Widget')

<a name='P-ExperimentalProject-Views-WidgetBoard-IsSidebarHidden'></a>
### IsSidebarHidden `property`

##### Summary

Gets or sets the visibility of sidebar with [WidgetPalette](#T-ExperimentalProject-Views-WidgetPalette 'ExperimentalProject.Views.WidgetPalette')

<a name='P-ExperimentalProject-Views-WidgetBoard-PaletteBackground'></a>
### PaletteBackground `property`

##### Summary

Gets or sets the filling the background for the widget palette field

<a name='P-ExperimentalProject-Views-WidgetBoard-PaletteForeground'></a>
### PaletteForeground `property`

##### Summary

Gets or sets the color for Group Labels and other stuff

<a name='P-ExperimentalProject-Views-WidgetBoard-SidebarWidth'></a>
### SidebarWidth `property`

##### Summary

Gets or sets the sidebar width with [WidgetPalette](#T-ExperimentalProject-Views-WidgetPalette 'ExperimentalProject.Views.WidgetPalette')

<a name='P-ExperimentalProject-Views-WidgetBoard-WidgetsOnBoard'></a>
### WidgetsOnBoard `property`

##### Summary

Gets or sets the collection of [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') located on a board

<a name='P-ExperimentalProject-Views-WidgetBoard-WidgetsPalette'></a>
### WidgetsPalette `property`

##### Summary

Gets or sets the collection of [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette') located on a
    board

<a name='M-ExperimentalProject-Views-WidgetBoard-#cctor'></a>
### #cctor() `method`

##### Summary

Class for handling interface logic and providing bindings

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-AddWidget-ExperimentalProject-Widget-'></a>
### AddWidget(widget) `method`

##### Summary

Add [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') to this WidgetBoard

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widget | [ExperimentalProject.Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') | Widget to add |

<a name='M-ExperimentalProject-Views-WidgetBoard-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-OnAutoCellSizeChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnAutoCellSizeChanged(d,e) `method`

##### Summary

Handler called when the [AutoCellSize](#P-ExperimentalProject-Views-WidgetBoard-AutoCellSize 'ExperimentalProject.Views.WidgetBoard.AutoCellSize') value changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnBoardBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnBoardBackgroundChanged(d,e) `method`

##### Summary

Handler called when the [BoardBackground](#P-ExperimentalProject-Views-WidgetBoard-BoardBackground 'ExperimentalProject.Views.WidgetBoard.BoardBackground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnBoardChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs-'></a>
### OnBoardChangedHandler(sender,e) `method`

##### Summary

Handler called when the [WidgetsOnBoard](#P-ExperimentalProject-Views-WidgetBoard-WidgetsOnBoard 'ExperimentalProject.Views.WidgetBoard.WidgetsOnBoard') collection changed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.Collections.Specialized.NotifyCollectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.NotifyCollectionChangedEventArgs 'System.Collections.Specialized.NotifyCollectionChangedEventArgs') | An object that describes a change in a collection |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnBoardForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnBoardForegroundChanged(d,e) `method`

##### Summary

Handler called when the [BoardForeground](#P-ExperimentalProject-Views-WidgetBoard-BoardForeground 'ExperimentalProject.Views.WidgetBoard.BoardForeground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnCellHeightChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnCellHeightChanged(d,e) `method`

##### Summary

Handler called when the [CellHeight](#P-ExperimentalProject-Views-WidgetBoard-CellHeight 'ExperimentalProject.Views.WidgetBoard.CellHeight') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnCellWidthChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnCellWidthChanged(d,e) `method`

##### Summary

Handler called when the [CellWidth](#P-ExperimentalProject-Views-WidgetBoard-CellWidth 'ExperimentalProject.Views.WidgetBoard.CellWidth') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') |  |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnCreateWidgetHandler-System-Object,ExperimentalProject-Widget-'></a>
### OnCreateWidgetHandler(sender,widget) `method`

##### Summary

Handler called when [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette') instance create a new
    [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| widget | [ExperimentalProject.Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') | Created [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') instance |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnGridColumnCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnGridColumnCountChanged(d,e) `method`

##### Summary

Handler called when the [GridColumnCount](#P-ExperimentalProject-Views-WidgetBoard-GridColumnCount 'ExperimentalProject.Views.WidgetBoard.GridColumnCount') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnGridRowCountChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnGridRowCountChanged(d,e) `method`

##### Summary

Handler called when the [GridRowCount](#P-ExperimentalProject-Views-WidgetBoard-GridRowCount 'ExperimentalProject.Views.WidgetBoard.GridRowCount') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnIsGridDisplayedChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsGridDisplayedChanged(d,e) `method`

##### Summary

Handler called when the [IsGridDisplayed](#P-ExperimentalProject-Views-WidgetBoard-IsGridDisplayed 'ExperimentalProject.Views.WidgetBoard.IsGridDisplayed') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnIsManipulatorHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsManipulatorHiddenChanged(d,e) `method`

##### Summary

Handler called when the [IsManipulatorHidden](#P-ExperimentalProject-Views-WidgetBoard-IsManipulatorHidden 'ExperimentalProject.Views.WidgetBoard.IsManipulatorHidden') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnIsSidebarHiddenChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnIsSidebarHiddenChanged(d,e) `method`

##### Summary

Handler called when the [IsSidebarHidden](#P-ExperimentalProject-Views-WidgetBoard-IsSidebarHidden 'ExperimentalProject.Views.WidgetBoard.IsSidebarHidden') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnLoad-System-Object,System-Windows-RoutedEventArgs-'></a>
### OnLoad(sender) `method`

##### Summary

Handler called when the [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') has been completely initialized

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance that has been initialized |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnPaletteBackgroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnPaletteBackgroundChanged(d,e) `method`

##### Summary

Handler called when the [PaletteBackground](#P-ExperimentalProject-Views-WidgetBoard-PaletteBackground 'ExperimentalProject.Views.WidgetBoard.PaletteBackground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnPaletteChangedHandler-System-Object,System-Collections-Specialized-NotifyCollectionChangedEventArgs-'></a>
### OnPaletteChangedHandler(sender,e) `method`

##### Summary

Handler called when the [WidgetsPalette](#P-ExperimentalProject-Views-WidgetBoard-WidgetsPalette 'ExperimentalProject.Views.WidgetBoard.WidgetsPalette') collection changed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.Collections.Specialized.NotifyCollectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Specialized.NotifyCollectionChangedEventArgs 'System.Collections.Specialized.NotifyCollectionChangedEventArgs') | An object that describes a change in a collection |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnPaletteForegroundChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnPaletteForegroundChanged(d,e) `method`

##### Summary

Handler called when the [PaletteForeground](#P-ExperimentalProject-Views-WidgetBoard-PaletteForeground 'ExperimentalProject.Views.WidgetBoard.PaletteForeground') changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs-'></a>
### OnSizeChanged(sender,e) `method`

##### Summary

Handler called when the [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') has been resized

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.SizeChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.SizeChangedEventArgs 'System.Windows.SizeChangedEventArgs') | An object that describes a size changing |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnWidgetsOnBoardChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnWidgetsOnBoardChanged(d,e) `method`

##### Summary

Handler called when the [WidgetsOnBoard](#P-ExperimentalProject-Views-WidgetBoard-WidgetsOnBoard 'ExperimentalProject.Views.WidgetBoard.WidgetsOnBoard') replaced

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnWidgetsPaletteChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnWidgetsPaletteChanged(d,e) `method`

##### Summary

Handler called when the [WidgetPalette](#F-ExperimentalProject-Views-WidgetBoard-WidgetPalette 'ExperimentalProject.Views.WidgetBoard.WidgetPalette') replaced

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard') instance whose property has been changed |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | An object that describes a change in a dependent property |

<a name='M-ExperimentalProject-Views-WidgetBoard-OnWidthAnimationCompletedHandler-System-Object,System-EventArgs-'></a>
### OnWidthAnimationCompletedHandler(sender,e) `method`

##### Summary

Handler called then transform animation is completed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object that initiated the change to the collection |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | Standard event arguments (empty) |

<a name='M-ExperimentalProject-Views-WidgetBoard-RemoveWidget-ExperimentalProject-Widget-'></a>
### RemoveWidget(widget) `method`

##### Summary

Remove [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') from WidgetBoard

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widget | [ExperimentalProject.Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') | Removed [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') instance |

<a name='M-ExperimentalProject-Views-WidgetBoard-RenderWidgetPalette'></a>
### RenderWidgetPalette() `method`

##### Summary

Draw a widget palettes in sidebar

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-ResizeGrid'></a>
### ResizeGrid() `method`

##### Summary

Update the positions of the background grid lines

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-ToggleAutoCellSize'></a>
### ToggleAutoCellSize() `method`

##### Summary

Update cell size by [AutoCellSize](#P-ExperimentalProject-Views-WidgetBoard-AutoCellSize 'ExperimentalProject.Views.WidgetBoard.AutoCellSize') value

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-ToggleWidgetManipulators'></a>
### ToggleWidgetManipulators() `method`

##### Summary

Toggles visibility of [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') Manipulators

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-ToggleWidgetSidebar'></a>
### ToggleWidgetSidebar() `method`

##### Summary

Toggles visibility of sidebar with [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette')

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-Views-WidgetBoard-UpdateGridDimensions'></a>
### UpdateGridDimensions() `method`

##### Summary

Complete updating grid lines

##### Parameters

This method has no parameters.

<a name='T-ExperimentalProject-Views-WidgetPalette'></a>
## WidgetPalette `type`

##### Namespace

ExperimentalProject.Views

##### Summary

Логика взаимодействия для WidgetPalette.xaml

<a name='T-ExperimentalProject-WidgetPalette'></a>
## WidgetPalette `type`

##### Namespace

ExperimentalProject

##### Summary

Represents a view model for [WidgetPalette](#T-ExperimentalProject-Views-WidgetPalette 'ExperimentalProject.Views.WidgetPalette') that provide instantiating
    [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') on a [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard').

<a name='M-ExperimentalProject-Views-WidgetPalette-#ctor'></a>
### #ctor() `constructor`

##### Summary

Represents a UI element that allows [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') of the specified type to
    be created on a [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard').

##### Parameters

This constructor has no parameters.

<a name='M-ExperimentalProject-WidgetPalette-#ctor-System-Type,System-Type,System-Type-'></a>
### #ctor(widgetType,widgetControlType,widgetViewModelType) `constructor`

##### Summary

Class that provides the ability to create widgets on a
    [WidgetBoard](#T-ExperimentalProject-Views-WidgetBoard 'ExperimentalProject.Views.WidgetBoard').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| widgetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of child class that should inherit
    [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') class. |
| widgetControlType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type that should inherit [UserControl](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.UserControl 'System.Windows.Controls.UserControl') and that will be
    embedded in the Widget. |
| widgetViewModelType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Occurs when types are passed as arguments that do not inherit the required classes. |

<a name='P-ExperimentalProject-WidgetPalette-CreateWidgetCommand'></a>
### CreateWidgetCommand `property`

##### Summary

Command that triggered [](#E-ExperimentalProject-WidgetPalette-OnCreateWidgetEvent 'ExperimentalProject.WidgetPalette.OnCreateWidgetEvent')

<a name='P-ExperimentalProject-WidgetPalette-GroupName'></a>
### GroupName `property`

##### Summary

Gets or sets the name for grouping widgets in the palette

<a name='P-ExperimentalProject-WidgetPalette-IconBase64'></a>
### IconBase64 `property`

##### Summary

Gets the Icon in Base64 format

<a name='P-ExperimentalProject-WidgetPalette-IconBytes'></a>
### IconBytes `property`

##### Summary

Gets or sets the ByteArray of SVG file for drawing the icon

<a name='P-ExperimentalProject-WidgetPalette-Title'></a>
### Title `property`

##### Summary

Gets or sets the title displayed in the interface of the [WidgetPalette](#T-ExperimentalProject-WidgetPalette 'ExperimentalProject.WidgetPalette')

<a name='P-ExperimentalProject-WidgetPalette-WidgetId'></a>
### WidgetId `property`

##### Summary

Gets or protected sets the widget variant ID

<a name='P-ExperimentalProject-WidgetPalette-WidgetPaletteView'></a>
### WidgetPaletteView `property`

##### Summary

Gets the view for WidgetPalette Control

<a name='M-ExperimentalProject-Views-WidgetPalette-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-WidgetPalette-CreateWidgetInstance'></a>
### CreateWidgetInstance() `method`

##### Summary

Creates a widget based on the types specified in the constructor.

##### Returns

Created [Widget](#T-ExperimentalProject-Widget 'ExperimentalProject.Widget') instance

##### Parameters

This method has no parameters.

<a name='M-ExperimentalProject-WidgetPalette-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(prop) `method`

##### Summary

Method that do trigger [](#E-ExperimentalProject-WidgetPalette-PropertyChanged 'ExperimentalProject.WidgetPalette.PropertyChanged')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| prop | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property name |
