#pragma checksum "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eab8162fcb2dae7f8255d03182baeef567f668c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Users\Index.cshtml"
using WebClient.Extentions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eab8162fcb2dae7f8255d03182baeef567f668c", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("gap: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Users\Index.cshtml"
  
	ViewData["Title"] = "Users";

	string accessToken = SessionManager.Authenticate(Context)?.AccessToken;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
	<div class=""card-header"">Users Panel</div>
	<div class=""card-body"">
		<div class=""row"">
			<div class=""col-md-12 text-white text-center"">
				<button name=""btn-function"" value=""getAll"" class=""btn btn-primary"">Refresh</button>
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eab8162fcb2dae7f8255d03182baeef567f668c6438", async() => {
                WriteLiteral("Create New User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
			</div>

			<div class=""col-md-12"">
				<h4>Infomation</h4>
				<hr />
				<table id=""table_users"" class=""table table-striped table-hover table-md-responsive text-center"">
					<thead class=""bg-primary text-white"">
						<tr>
							<th>Id</th>
							<th>Email</th>
							<th>FullName</th>
							<th>HireDate</th>
							<th>Role</th>
							<th>Source</th>
							<th>Publisher</th>
							<th>...</th>
						</tr>
						<tr id=""loading"">
							<td colspan=""8"">
								<div class=""spinner-border text-secondary"" role=""status"">
									<span class=""sr-only"">Loading...</span>
								</div>
							</td>
						</tr>
					</thead>
					<tbody>
						
					</tbody>
				</table>
				

				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eab8162fcb2dae7f8255d03182baeef567f668c8511", async() => {
                WriteLiteral(@"
					<hr />
					<div class=""row"">
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Id"">Id</label>
							<input type=""text"" readonly class=""form-control"" id=""Id"" name=""Id"" placeholder=""User Id""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""FirstName"">FirstName</label>
							<input type=""text"" class=""form-control"" id=""FirstName"" name=""FirstName"" placeholder=""User FirstName""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""MiddleName"">MiddleName</label>
							<input type=""text"" class=""form-control"" id=""MiddleName"" name=""MiddleName"" placeholder=""User MiddleName""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""LastName"">LastName</label>
							<input type=""text"" class=""form-control"" id=""LastName"" name=""LastName"" placeholder=""User LastName""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Source"">Source</label>
							<input type=""te");
                WriteLiteral(@"xt"" class=""form-control"" id=""Source"" name=""Source"" placeholder=""User Source""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""HireDate"">HireDate</label>
							<input type=""date"" class=""form-control"" id=""HireDate"" name=""HireDate"" placeholder=""User HireDate""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Publisher"">Publisher</label>
							<select class=""form-control"" id=""Publisher"" name=""PublisherId"" placeholder=""User Publisher"">

							</select>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Role"">Role</label>
							<select class=""form-control"" id=""Role"" name=""RoleId"" placeholder=""User Role"">

							</select>
						</div>
						<div class=""m-2 col-sm-12 text-center"">
							<button type=""button"" id=""form_close"" class=""btn btn-danger"">Close</button>
							<button type=""submit"" class=""btn btn-success"">Save</button>
						</div>
					</div>
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script>\r\n\r\n\t\t// Definition\r\n\r\n\t\tvar baseUrl = \"https://localhost:44310/api/\";\r\n\r\n\t\t$.ajaxSetup({\r\n\t\t   headers:{\r\n                \'Authorization\': \"Bearer \" + \"");
#nullable restore
#line 107 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Users\Index.cshtml"
                                         Write(accessToken);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
		   }
		});

		var users = [];
		var publishers = [];
		var roles = [];
		var selectedUser = null;
		var currentSelectedIndex = -1;


		var getAllPublisher = function() {

			$.get(baseUrl + ""Publishers"", function(data, status)
			{
                if (status == ""success"") {
                    publishers = data;
                    console.log(publishers);
                    fillPublisherToSelectBox(publishers);
                }
                else {
                    alert(data);
				}
			});

		}

		var fillPublisherToSelectBox = function(dataset) {
            let dataRow = """";

			dataset.forEach((publisher, idx) => {
                dataRow += 
				`
				<option value=${publisher.id}>${publisher.name}</option>
				`;
            });

            $(""#Publisher"").append(dataRow);

		}

		var getAllRole = function() {

			$.get(baseUrl + ""Roles"", function(data, status)
			{
                if (status == ""success"") {
                    roles = data;
  ");
                WriteLiteral(@"                  console.log(roles);
                    fillRoleToSelectBox(roles);
                }
                else {
                    alert(data);
				}
			});

		}

		var fillRoleToSelectBox = function(dataset) {
            let dataRow = """";

			dataset.forEach((role, idx) => {
                dataRow += 
				`
				<option value=${role.id}>${role.description}</option>
				`;
            });

            $(""#Role"").append(dataRow);

		}

		var getAllUser = function() {

			$(""#table_users"").show();
            $(""#loading"").show(0.5);

			$.get(baseUrl + ""Users"", function(data, status)
			{
                if (status == ""success"") {
                    $(""#loading"").hide(0.5);
                    users = data;
                    renderUser(users);
                }
                else {
                    alert(data);
				}
			});
            
		}

		var renderUser = function(dataset) {
            
            let dataRow = """";
			
			dataset.fo");
                WriteLiteral(@"rEach((user, idx) => {
                dataRow += 
				`
				<tr id=""${user.id}"">
					<td>${user.id}</td>
					<td>${user.email}</td>
					<td>${user.fullName}</td>
					<td>${user.hireDate}</td>
					<td>${user.role.description}</td>
					<td>${user.source}</td>
					<td>${user.publisher.name}</td>
					<td>
						<button name=""btn-update"" class=""btn btn-success m-1"" value=""${idx}"">Edit</button>
						<button name=""btn-delete"" class=""btn btn-danger m-1"" value=""${idx}"">Remove</button>
					</td>
				<tr>
				`; 
            });

            $(""#table_users tbody"").html(dataRow);
            addFillDataEvent();

		}

		var fillUserInfo = function(user) {

            $(""#Id"").val(user.id);
            $(""#FirstName"").val(user.firstName);
            $(""#MiddleName"").val(user.middleName);
            $(""#LastName"").val(user.lastName);
            $(""#Source"").val(user.source);
            $(""#HireDate"").val(user.hireDate);
            $(""#Publisher"").val(user.publisher.id);
   ");
                WriteLiteral(@"         $(""#Role"").val(user.role.id);
		};

		var updateBtnClicked = (e) => {

            console.log(""update clicked!"");
            let idx = e.currentTarget.value;
            selectedUser = users[idx];
            currentSelectedIndex = idx;
            fillUserInfo(selectedUser);
			$(""#form_user"").show(0.8);
		}

		var deleteBtnClicked = (e) => {
			console.log(""delete clicked!"");
            
			let idx = e.currentTarget.value;
			let deleteSelectedUser = users[idx];

            if (confirm(`Delete user with Id=${deleteSelectedUser.id}? You cannot reverse data!`)) {
				
				$.ajax({
				type: 'delete',
                headers: {
					""Content-Type"": ""application/json""
				},
				url: baseUrl + ""Users"" + ""/"" + deleteSelectedUser.id,
				success: function () {
					alert('Request was successful.');
                    if (deleteSelectedUser === selectedUser) {
						selectedUser = null;
						currentSelectedIndex = -1;
					}
                    $(`#${deleteSelectedUs");
                WriteLiteral(@"er.id}`).hide(1);
				},
				error: function (err) {
					alert('An error occurred: ' + err.responseText);
					console.log(err.responseText);
				},
			});
			}
		}

		var addFillDataEvent = () => {
			$(""button[name='btn-update']"").click(updateBtnClicked);
			$(""button[name='btn-delete']"").click(deleteBtnClicked);
		}

		$(""button[name='btn-function']"").click((e) => {

			let type = e.target.value;
			switch(type) {
                case ""getAll"":
                    getAllUser();
                    break;
			}

		});

		var frm = $('#form_user');
		frm.submit(function (e) {

			e.preventDefault();

            var object = {};
			(new FormData(e.target)).forEach(function(value, key){
				object[key] = value;
			});
			var json = JSON.stringify(object);
            console.log(""Submit(put): "" + json);
			$.ajax({
				type: 'put',
                headers: {
					""Content-Type"": ""application/json"",
				},
				url: baseUrl + ""Users"",
				data: json,
				success: func");
                WriteLiteral(@"tion (user) {
					alert('Submission was successful.');
					console.log(user);
                    let newRow =
                    `
					<tr id=""${user.id}"">
						<td>${user.id}</td>
						<td>${user.email}</td>
						<td>${user.fullName}</td>
						<td>${user.hireDate}</td>
						<td>${user.role.description}</td>
						<td>${user.source}</td>
						<td>${user.publisher.name}</td>
						<td>
							<button name=""btn-update"" class=""btn btn-success m-1"" value=""${currentSelectedIndex}"">Edit</button>
							<button name=""btn-delete"" class=""btn btn-danger m-1"" value=""${currentSelectedIndex}"">Remove</button>
						</td>
					<tr>
					`;
                    $(`#${user.id}`).replaceWith(newRow);
                    users[currentSelectedIndex] = user;
				},
				error: function (err) {
					alert('An error occurred: ' + err.responseText);
					console.log(err.responseText);
				},
			});
		});

		$(""#form_close"").click(() => {
			$(""#form_user"").hide();
		});

		function Init() {");
                WriteLiteral("\n            $(\"#loading\").hide();\r\n            $(\"#table_users\").hide();\r\n            $(\"#form_user\").hide();\r\n\r\n            getAllPublisher();\r\n            getAllRole();\r\n\t\t\tgetAllUser();\r\n\r\n\t\t}\r\n\r\n\t\tInit();\r\n\r\n\t</script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
