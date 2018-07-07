using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AngularXam.ViewModels
{
    public  class AngularDetailPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        string data = string.Empty;
        public string Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }
        }

        string whyData = string.Empty;
        public string WhyData
        {
            get { return whyData; }
            set { SetProperty(ref whyData, value); }
        }

        public AngularDetailPageViewModel()
        {
            data = "AngularJS (commonly referred to as Angular.js or AngularJS) is a JavaScript-based " +
                "open-source front-end web application framework mainly maintained by Google \n "+
                "Angular is a platform that makes it easy to " +
                "build applications with the web.\n Angular combines declarative templates, " +
                "dependency injection, end to end tooling, and integrated best practices to" +
                " solve development challenges.\n Angular empowers developers to build applications" +
                " that live on the web, mobile, or the desktop";

            whyData = "1.MVC Done Right \n" +
                "2. A Declarative User Interface \n" +
                "3. Data Models Are plain old JavaScript objects( POJO) \n" +
                "4. Behavior With Directives \n" +
                "5. Flexibility With Filters \n" +
                "6. Write Less Code \n" +
                "7. DOM Manipulations Where They Belong \n" +
                "8. Unit Testing Ready ";
                
        }
    }
}
