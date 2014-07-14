using System;
using System.Net;
using System.Net.Http;
using System.Text;
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

        private void POSTFunction(string endpoint, StringContent content)
        {
            HttpResponseMessage response = _client.PostAsync(endpoint, content).Result;
            txtOutput.Text += Environment.NewLine + response;
        }

        private void PUTFunction(string endpoint, StringContent content)
        {
            HttpResponseMessage response = _client.PutAsync(endpoint, content).Result;
            txtOutput.Text += Environment.NewLine + response;
        }

        public Form1()
        {
            InitializeComponent();
            txtIPAddress.Text = @"172.16.124.28"; //put your Smartlaunch Server IP Address here.
            NewConnection();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            NewConnection();
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
            var content = new StringContent(@"{""UserCreate"":{""UserName"":""edwin2"",""UsergroupName"":""Members""}}",
                                            Encoding.UTF8, "application/json");
            POSTFunction("/users", content);
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
            var content = new StringContent(@"{""UserUpdate"":{""FirstName"":""Edwin"",""LastName"":""Smartlaunch"",""Birthday"":531831420,""Address"":""Power House"",""City"":""Gianyar"",""Zip"":""80582"",""State"":""Bali"",""Country"":""Indonesia"",""Email"":""ek@smartlaunch.com"",""Telephone"":""12345678"",""MobilePhone"":""87654321"",""Sex"":1,""PersonalNumber"":""99999""}}",
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin", content);
        }

        private void UserMoveUserGroup_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/moveusergroup?newusergroupid={newusergroupid}");
            PUTFunction("/users/edwin/moveusergroup?newusergroupid=2", null );
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
            PUTFunction("/users/edwin/open", null);
        }

        private void UserLock_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/lock");
            PUTFunction("/users/edwin/lock", null);
        }

        private void UserGetBill_Click(object sender, EventArgs e)
        {
            WriteOutput("GET /users/{username}/bill");
            GETFunction("/users/edwin/bill");
        }

        public class UserAddTime
        {
            public int Minutes { get; set; }
            public double TotalPrice { get; set; }
            public bool IsTaxIncluded { get; set; }
        }
        private void ButtonUserAddTime_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addtime");

            var content = new StringContent(@"{""UserAddTime"":{""Minutes"":60,""TotalPrice"":1.00,""IsTaxIncluded"":true}}", 
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin/addtime", content);
        }

        public class UserAddMoney
        {
            public double Amount { get; set; }
        }
        private void ButtonUserAddMoney_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addmoney");

            var content = new StringContent(@"{""UserAddMoney"":{""Amount"":12.50}}",
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin/addmoney", content);
        }

        public class UserAddProduct
        {
            public string ProductID { get; set; }
            public int Quantity { get; set; }
            public int Paymode { get; set; }
            public double TotalPrice { get; set; }
            public bool IsTaxIncluded { get; set; }
            public string Note { get; set; }
        }
        private void ButtonUserAddProduct_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addproduct");
            var content = new StringContent(@"{""UserAddProduct"":{""ProductID"":""39"",""Quantity"":1,""Paymode"":1,""TotalPrice"":1.10,""IsTaxIncluded"":true,""Note"":""""}}",
                                            Encoding.UTF8, "application/json"); 
            PUTFunction("/users/edwin/addproduct", content);
        }

        public class UserProduct
        {
            public string ProductID { get; set; }
            public int Quantity { get; set; }
            public double TotalPrice { get; set; }
            public string Note { get; set; }
        }
        public class UserAddProducts
        {
            public UserProduct[] Products { get; set; }
            public int Paymode { get; set; }
            public bool IsTaxIncluded { get; set; }
        }
        private void ButtonUserAddProducts_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addproducts");
            var content = new StringContent(@"{""UserAddProducts"":{""Products"":[{""ProductID"":""39"",""Quantity"":1,""TotalPrice"":1.10,""Note"":""""},{""ProductID"":""26"",""Quantity"":1,""TotalPrice"":2.10,""Note"":""""}],""Paymode"":1,""IsTaxIncluded"":true}}",
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin/addproducts", content);
        }

        public class UserAddOffer
        {
            public string OfferID { get; set; }
            public int Quantity { get; set; }
            public int Paymode { get; set; }
            public double TotalPrice { get; set; }
            public bool IsTaxIncluded { get; set; }
            public bool IsFixedStart { get; set; }
            public double StartDate { get; set; }
            public string Note { get; set; }
        }
        private void ButtonUserAddOffer_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addoffer");
            var content = new StringContent(@"{""UserAddOffer"":{""OfferID"":""1"",""Quantity"":1,""Paymode"":1,""TotalPrice"":1.10,""IsTaxIncluded"":true,""IsFixedStart"":true,""StartDate"":1404484200,""Note"":""""}}",
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin/addoffer", content);
        }

        public class UserOffer
        {
            public string OfferID { get; set; }
            public int Quantity { get; set; }
            public double TotalPrice { get; set; }
            public bool IsFixedStart { get; set; }
            public double StartDate { get; set; }
            public string Note { get; set; }
        }
        public class UserAddOffers
        {
            public UserOffer[] Offers { get; set; }
            public int Paymode { get; set; }
            public bool IsTaxIncluded { get; set; }
        }
        private void ButtonUserAddOffers_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /users/{username}/addoffers");
            var content = new StringContent(@"{""UserAddOffers"":{""Offers"":[{""OfferID"":""1"",""Quantity"":1,""TotalPrice"":1.10,""IsFixedStart"":true,""StartDate"":1404484200,""Note"":""""},{""OfferID"":""2"",""Quantity"":1,""TotalPrice"":2.10,""IsFixedStart"":true,""StartDate"":1404484200,""Note"":""""}],""Paymode"":1,""IsTaxIncluded"":true}}",
                                            Encoding.UTF8, "application/json");
            PUTFunction("/users/edwin/addoffers", content);
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
            PUTFunction("/computers/PC001/turnon", null);
        }

        private void ButtonComputerTurnOff_Click(object sender, EventArgs e)
        {
            WriteOutput("PUT /computers/{computername}/turnoff");
            PUTFunction("/computers/PC001/turnoff", null);
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
