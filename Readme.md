<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_BeginEndUpdate/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_BeginEndUpdate/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_BeginEndUpdate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_BeginEndUpdate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to lock pivot grid updates


<p>The following example demonstrates how to lock the pivot grid, thus preventing it from being redrawn while a sequence of operations that affect its appearance and/or functionality is being performed.</p><p>In this example, the pivot grid is transposed by moving Row Fields to the Column Area, and vice versa. Prior to this, the BeginUpdate method is called to lock the pivot grid. When the transposition is completed, the pivot grid is unlocked via the EndUpdate method. To ensure that the EndUpdate method is always called even if an exception occurs, calls to the BeginUpdate and EndUpdate methods are wrapped in a <strong>try...finally</strong> statement.</p><p></p>

<br/>


