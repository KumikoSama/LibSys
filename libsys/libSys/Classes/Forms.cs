using System;
using System.Collections.Generic;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.FormsFolder;
using LibrarySystem.SideForms;

namespace LibrarySystem.Classes
{
    public class FormFactory : KryptonForm
    {
        public static T CreateForm<T>() where T : KryptonForm, new()
        {
            return new T();
        }
    }

    public static class Forms
    {
        public static Dashboard Dashboard() => FormFactory.CreateForm<Dashboard>();
        public static FrontPage FrontPage() => FormFactory.CreateForm<FrontPage>();
        public static RegistrationForm RegistrationForm() => FormFactory.CreateForm<RegistrationForm>();
        public static ManageBooks ManageBooks() => FormFactory.CreateForm<ManageBooks>();
        public static PendingRequests PendingRequests() => FormFactory.CreateForm<PendingRequests>();
        public static MembersInfo MembersInfo() => FormFactory.CreateForm<MembersInfo>();
    }
}
