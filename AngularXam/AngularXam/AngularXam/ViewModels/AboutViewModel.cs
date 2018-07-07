using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AngularXam.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Versions";
            versionData1 = " The architecture of AngularJS is based " +
                "on MVC whereas the architecture of Angular 2 is based on service/controller\n" +
                "Angular JS use JavaScript to build the application while from Angular v2.0" +
                " angular team introduced the typescript to write the application. \n" +
                "The controller concept which was present in Angular v1.0 is eliminated" +
                " in Angular v2.0. Angular v2.0 has changed to component based UI. " +
                "With AngularJS development the search engine friendly Single Page " +
                "Applications was the major difficulty. But this bottleneck was " +
                "eliminated in Angular v2.0";

            versionData2 = "Upgrade of the version from 2.0 to 4.0 has reduced it’s" +
                " bundled file size by 60%. " +
                "The code generated is reduced and has accelerated the application development. \n" +
                "Angular v4.0 is compatible with newer versions TypeScript 2.1 and TypeScript 2.2. \n" +
                "Angular 2.0 has made it possible to accomplish the native applications for a mobile " +
                "platform like React Native. ";

            VersionData4 = "The Angular 5 Contains bunch of new features, performance improvements" +
                " and lot of bug fixes" +
                "The Angular 5 comes with enhanced compiler for supporting" +
                " incremental compilation. \n" +
                " Watch mode \n" +
                "Type checking in templates \n " +
                "More flexible metadata \n" +
                "Angular 5 is equipped with build optimizer which is a part of the platform’s " +
                "command like tool. \n" +
                "Internationalized Number, Date, and Currency Pipes \n" +
                "Multiple Export Aliases \n";

            versionData5 = "The highlights of Angular 6 include the " +
                "Angular Command Line Interface (CLI), The Component Development KIT (CDK) " +
                "and the Angular Material package update \n" +
                "The Angular Material Design Library \n" +
                "Multiple Validators For Your Forms \n" +
                "Tree Shakable Service \n" +
                "Web Pack Updated";
       //     OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        string versionData1 = string.Empty;
        public string VersionData1
        {
            get { return versionData1; }
            set { SetProperty(ref versionData1, value); }
        }

        string versionData2 = string.Empty;
        public string VersionData2
        {
            get { return versionData2; }
            set { SetProperty(ref versionData2, value); }
        }
        string versionData4 = string.Empty;
        public string VersionData4
        {
            get { return versionData4; }
            set { SetProperty(ref versionData4, value); }
        }

        string versionData5 = string.Empty;
        public string VersionData5
        {
            get { return versionData5; }
            set { SetProperty(ref versionData5, value); }
        }
        public ICommand OpenWebCommand { get; }
    }
}