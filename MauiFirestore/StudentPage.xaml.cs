using MauiFirestore.Services;
using MauiFirestore.ViewModels;

namespace MauiFirestore;

public partial class SamplePage : ContentPage
{
	public SamplePage()
	{
		InitializeComponent();
		var firestoreService = new FirestoreService();
		BindingContext = new StudentViewModel(firestoreService);
	}
}