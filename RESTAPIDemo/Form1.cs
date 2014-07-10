using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        private Uri UriAddress { get; set; }
        private HttpClient _client;

        private void NewConnection()
        {
            IPAddress tmpIP;
            int tmpPort;
            if (IPAddress.TryParse(txtIPAddress.Text, out tmpIP) && int.TryParse(txtPort.Text, out tmpPort))
            {
                UriAddress = new Uri(String.Format("http://{0}:{1}", tmpIP, tmpPort));

                _client = new HttpClient();
                _client.BaseAddress = UriAddress;
            }
        }

        private void WriteOutput(string endPointName)
        {
            txtOutput.Text = string.Format("{0}{1}{1}", endPointName, Environment.NewLine);
        }

        private void GETFunction(string endpoint)
        {
            HttpResponseMessage response = _client.GetAsync(endpoint).Result;
            HttpContent stream = response.Content;
            var data = stream.ReadAsStringAsync();
            txtOutput.Text += data.Result;
            txtOutput.Text += Environment.NewLine + Environment.NewLine + response;
        }

        private void POSTFunction(string endpoint, object parameter)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync(endpoint, parameter).Result;
            txtOutput.Text += Environment.NewLine + response;
        }

        private void PUTFunction(string endpoint, object parameter)
        {
            HttpResponseMessage response = _client.PutAsJsonAsync(endpoint, parameter).Result;
            txtOutput.Text += Environment.NewLine + response;
        }

        public Form1()
        {
            InitializeComponent();
            txtIPAddress.Text = @"172.16.124.69"; //put your Smartlaunch Server IP Address here.
            NewConnection();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            NewConnection();
        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

#region "USERS"
        private void UserAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users");
            GETFunction("/users");
        }

        private void UserAllByNumberOfUsers_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/byid?startid={startid}&numberofusers={numberofuser}");
            GETFunction("/users/byid?startid=1&numberofusers=1");
        }

        private void UserAllByStatus_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/bystatus?status={status}");
            GETFunction("/users/bystatus?status=false");
        }

        private void User_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}");
            GETFunction("/users/edwin");
        }

        public class UserCreate
        {
            public string UserName { get; set; }
            public string UsergroupName { get; set; }
        }
        private void UserCreate_Click(object sender, EventArgs e)
        {
            WriteOutput("POST /users");
            POSTFunction("/users", new UserCreate { UserName = "edwin2", UsergroupName = "Members" });
        }

        public class UserUpdate
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Birthday { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
            public string MobilePhone { get; set; }
            public int Sex { get; set; }
            public string PersonalNumber { get; set; }
        }
        private void UserUpdate_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}");
            PUTFunction("/users/edwin", new UserUpdate { FirstName = "Edwin", LastName = "Smartlaunch", Birthday = 531831420, Address = "Power House", City = "Gianyar", Zip = "80582", State = "Bali", Country = "Indonesia", Email = "ek@smartlaunch.com", Telephone = "12345678", MobilePhone = "87654321", Sex = 1, PersonalNumber = "99999" });
        }

        private void UserMoveUserGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/moveusergroup?newusergroupid={newusergroupid}");
            PUTFunction("/users/edwin/moveusergroup?newusergroupid=2", new object() );
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/login?computername={computername}");
            GETFunction("/users/edwin/login?computername=PC001");
        }

        private void UserLoginToConsole_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/logintoconsole?consolename={consolename}&controllerid={controllerid}");
            GETFunction("/users/edwin/logintoconsole?consolename=PS4001&controllerid=1");
        }

        private void UserLogin2_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/login2?computername={computername}&password={password}");
            GETFunction("/users/edwin/login2?computername=PC001&password=123456");
        }

        private void UserLogout_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/logout");
            GETFunction("/users/edwin/logout");
        }

        private void UserOpen_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/open");
            PUTFunction("/users/edwin/open", new object());
        }

        private void UserLock_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/lock");
            PUTFunction("/users/edwin/lock", new object());
        }

        private void UserGetBill_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/bill");
            GETFunction("/users/edwin/bill");
        }
#endregion

#region "USERGROUPS"
        private void UserGroupAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /usergroups");
            GETFunction("/usergroups");
        }

        private void UserGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /usergroups/{usergroupname}");
            GETFunction("/usergroups/Members");
        }
#endregion

#region "COMPUTERS"
        private void ButtonComputerAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /computers");
            GETFunction("/computers");
        }

        private void ButtonComputer_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /computers/{computername}");
            GETFunction("/computers/PC001");
        }

        private void ButtonComputerTurnOn_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /computers/{computername}/turnon");
            PUTFunction("/computers/PC001/turnon", new object());
        }

        private void ButtonComputerTurnOff_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /computers/{computername}/turnoff");
            PUTFunction("/computers/PC001/turnoff", new object());
        }

        private void ButtonComputerGroupAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /computergroups");
            GETFunction("/computergroups");
        }

        private void ButtonComputerGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /computergroups/{computergroupname}");
            GETFunction("/computergroups/Default");
        }

        private void ButtonComputerGroupByComputerName_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /computergroups/bycomputername?computername={computername}");
            GETFunction("/computergroups/bycomputername?computername=PC001");
        }

        private void ButtonLayoutGroupAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /layoutgroups");
            GETFunction("/layoutgroups");
        }

        private void ButtonLayoutGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /layoutgroups/{layoutgroupname}");
            GETFunction("/layoutgroups/All%20Computers");
        }

        private void ButtonLayoutGroupByComputerGroupName_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /layoutgroups/bycomputergroupname?computergroupname={computergroupname}");
            GETFunction("/layoutgroups/bycomputergroupname?computergroupname=Default");
        }

        private void ButtonLayoutGroupByComputerName_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /layoutgroups/bycomputername?computername={computername}");
            GETFunction("/layoutgroups/bycomputername?computername=PC001");
        }
#endregion

#region "PRODUCTS AND OFFERS"
        private void ButtonProductGroupAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /productgroups");
            GETFunction("/productgroups");
        }

        private void ButtonProductGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /productgroups/{productgroupname}");
            GETFunction("/productgroups/Chocolate");
        }

        private void ButtonProductAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /products");
            GETFunction("/products");
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /products/{productname}");
            GETFunction("/products/Chocolate%20Bar");
        }

        private void ButtonOfferAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /offers");
            GETFunction("/offers");
        }

        private void ButtonOffer_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /offers");
            GETFunction("/offers/Offer1");
        }
#endregion

#region "EMPLOYEES"
        private void ButtonEmployeeAll_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /employees");
            GETFunction("/employees");
        }

        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /employees");
            GETFunction("/employees/Admin");
        }

        private void ButtonEmployeeLogin_Click(object sender, EventArgs e)
        {
            WriteOutput("/employees/{employeename}/login?password={password}");
            GETFunction("/employees/Admin/login?password=12345678");
        }
#endregion

#region "FINANCIAL REPORTS"
        private void ButtonFinancialReport_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /financialreport/startdate={startdate}&enddate={enddate}&employeename={employeename}");
            GETFunction("/financialreport/startdate=1404172800&enddate=1404950400&employeename=Admin");
        }
#endregion

#region "GENERAL"
        private void ButtonRESTAPIVersion_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /restapiversion");
            GETFunction("/restapiversion");
        }

        private void ButtonSmartlaunchVersion_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /smartlaunchversion");
            GETFunction("/smartlaunchversion");
        }
#endregion

    }
}
