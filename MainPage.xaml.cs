﻿using System.Collections.ObjectModel;

namespace Maui_IssueCollectionView;

public partial class MainPage : ContentPage
{
	public ObservableCollection<TestItem> TestItems = new ObservableCollection<TestItem>();

	public MainPage()
	{
		InitializeComponent();

        TestItems.Add(new TestItem() { ItemName = "a" });
        TestItems.Add(new TestItem() { ItemName = "b" });
        TestItems.Add(new TestItem() { ItemName = "c" });
        TestItems.Add(new TestItem() { ItemName = "d" });
        TestItems.Add(new TestItem() { ItemName = "e" });
        TestItems.Add(new TestItem() { ItemName = "f" });
        TestItems.Add(new TestItem() { ItemName = "g" });

        cvTestItem.ItemsSource = TestItems;
    }
}

public class TestItem
{
	public string ItemName { get; set; }
}

