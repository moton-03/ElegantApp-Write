using Microsoft.UI.Xaml.Controls;
using Write.ViewModels;

using System;
using System.Collections.Generic;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Provider;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI;
using System.Runtime.InteropServices;
using WinRT;
using Windows.Graphics;

namespace Write.Views;

public sealed partial class MainPage : Page
{
    // var
    string path = "";

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    void UpdateTextBox()
    {
        if (path == "")
        {
            TextBox.Text = "";
        }
        else
        {

        }
    }

    private void New_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        path = "";
        UpdateTextBox();
    }

    private void Open_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        UpdateTextBox();
    }

    private void Save_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        UpdateTextBox();
    }

    private void SaveAs_Click(object sender, RoutedEventArgs e)
    {
        UpdateTextBox();
    }

    private void Text_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Time_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Undo_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.Undo();
    }

    private void Redo_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.Redo();
    }

    private void SelectAll_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.SelectAll();
    }

    private void MoveCursor_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Cut_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.CutSelectionToClipboard();
    }

    private void Copy_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.CopySelectionToClipboard();
    }

    private void Paste_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TextBox.PasteFromClipboard();
    }

    private void Delete_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Find_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void ClearHistory_Click(object sender, RoutedEventArgs e)
    {
        TextBox.ClearUndoRedoHistory();
    }

    private void Warp_Checked(object sender, RoutedEventArgs e)
    {
        TextBox.TextWrapping = TextWrapping.Wrap;
    }

    private void Warp_Unchecked(object sender, RoutedEventArgs e)
    {
        TextBox.TextWrapping = TextWrapping.NoWrap;
    }
}
