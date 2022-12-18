<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578821/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2724)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_BeginEndUpdate/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_BeginEndUpdate/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_BeginEndUpdate/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_BeginEndUpdate/MainWindow.xaml.vb))
<!-- default file list end -->
# How to lock pivot grid updates


<p>The following example demonstrates how to lock the pivot grid, thus preventing it from being redrawn while a sequence of operations that affect its appearance and/or functionality is being performed.</p><p>In this example, the pivot grid is transposed by moving Row Fields to the Column Area, and vice versa. Prior to this, the BeginUpdate method is called to lock the pivot grid. When the transposition is completed, the pivot grid is unlocked via the EndUpdate method. To ensure that the EndUpdate method is always called even if an exception occurs, calls to the BeginUpdate and EndUpdate methods are wrapped in a <strong>try...finally</strong> statement.</p><p></p>

<br/>


