using System;
using System.Collections.Generic;
using Plugin.Media;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class AddEmployee : ContentPage
    {
        //EmployeeViewModel empvm;
        string path;
        public AddEmployee()
        {
            InitializeComponent();
            //empvm = new EmployeeViewModel();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (pickerNationality.SelectedItem != null)
            {
                if (PickerSex.SelectedItem != null)
                {
                    Employee empdetail = new Employee();
                    empdetail.Address = address.Text;
                    empdetail.Name = name.Text;
                    empdetail.Sex = PickerSex.SelectedItem.ToString();
                    empdetail.DOB = PickerDob.Date.ToString("dd/MM/yyyy");
                    empdetail.Nationality = pickerNationality.SelectedItem.ToString();
                    empdetail.Designation = designation.Text;
                    empdetail.Imagepath = path;
                    ViewModelLocator.MainViewModel.EmployeeModel = empdetail;
                    Navigation.PushAsync(new DetailsEmployee(empdetail));
                }
                else
                {
                    DisplayAlert("Error", "Please select Gender", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Please select Nationality", "OK");
            }
            //throw new NotImplementedException();
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            try
            {
                await CrossMedia.Current.Initialize();
                // var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
                var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                if (storageStatus != PermissionStatus.Granted)
                {
                    var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Storage });
                    //cameraStatus = results[Permission.Camera];
                    storageStatus = results[Permission.Storage];
                }

                if (storageStatus == PermissionStatus.Granted)
                {
                    if (!CrossMedia.Current.IsPickPhotoSupported)
                    {
                       await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                        return;
                    }
                    var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                    {
                        PhotoSize = Plugin.Media.Abstractions.PhotoSize.Small,

                    });

                    if (file == null)
                        return;

                    UserImg.Source = ImageSource.FromStream(() =>
                    {
                        path = file.Path;
                        var stream = file.GetStream();
                        file.Dispose();
                        return stream;
                    });
                }
                else
                {
                    await DisplayAlert("Permissions Denied", "Unable to take photos.", "OK");
                    //On iOS you may want to send your user to the settings screen.
                    //CrossPermissions.Current.OpenAppSettings();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
