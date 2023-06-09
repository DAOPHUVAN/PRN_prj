#pragma checksum "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab479b2ce375f0d09240f839cc7af489ae19b0f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab479b2ce375f0d09240f839cc7af489ae19b0f0", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("gap: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hello\Downloads\PRN231 (1)\PRN231\Downloads\BookManagement-master\BookManagement-master\WebClient\Views\Books\Index.cshtml"
  
	ViewData["Title"] = "Books";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
	<div class=""card-header"">Books Panel</div>
	<div class=""card-body"">
		<div class=""row"">
			<div class=""col-md-12 text-white text-center"">
				<button id=""btn-refresh"" class=""btn btn-primary"">Refresh</button>
				<button id=""btn-create"" class=""btn btn-secondary"">Create New</button>
			</div>
			<div class=""col-md-12"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab479b2ce375f0d09240f839cc7af489ae19b0f05432", async() => {
                WriteLiteral(@"
					<h4>Please fill information below</h4>
					<hr />
					<div class=""row"">
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Title_Create"">Title</label>
							<input type=""text"" class=""form-control"" id=""Title_Create"" name=""Title"" placeholder=""Enter Title""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Type_Create"">Type/Genre</label>
							<select class=""form-control"" id=""Type_Create"" name=""Type"" placeholder=""Select Type"">

							</select>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Publisher_Create"">Publisher</label>
							<select class=""form-control"" id=""Publisher_Create"" name=""PublisherId"">

							</select>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""UrlDownload_Create"">Url Download</label>
							<input type=""text"" class=""form-control"" id=""UrlDownload_Create"" name=""UrlDownload"" placeholder=""Enter Price""/>
						</div>

						<div class=""form-");
                WriteLiteral(@"group col-lg-4 col-md-6"">
							<label for=""Note_Create"">Note</label>
							<input type=""text"" class=""form-control"" id=""Note_Create"" name=""Note"" placeholder=""Enter Note""/>
						</div>
						
						<div class=""m-2 col-sm-12 text-center"">
							<button type=""button"" id=""form_create_close"" class=""btn btn-danger"">Close</button>
							<button type=""submit"" class=""btn btn-success"">Create</button>
						</div>
					</div>
				");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
				<h4>Information</h4>
				<hr />
				<table id=""table_items"" class=""table table-striped table-hover table-md-responsive text-center"">
					<thead class=""bg-primary text-white"">
						<tr>
							<th>Id</th>
							<th>Title</th>
							<th>Type/Genre</th>
							<th>Url Download</th>
							<th>Publisher</th>
							<th>Note</th>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab479b2ce375f0d09240f839cc7af489ae19b0f09128", async() => {
                WriteLiteral(@"
					<hr />

					<div class=""row"">

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Id_Update"">Id</label>
							<input type=""text"" readonly class=""form-control"" id=""Id_Update"" name=""Id""/>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Title_Update"">Title</label>
							<input type=""text"" class=""form-control"" id=""Title_Update"" name=""Title"" placeholder=""Enter Title""/>
						</div>
						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Type_Update"">Type/Genre</label>
							<select class=""form-control"" id=""Type_Update"" name=""Type"" placeholder=""Select Type"">

							</select>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Publisher_Update"">Publisher</label>
							<select class=""form-control"" id=""Publisher_Update"" name=""PublisherId"">

							</select>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""UrlDownload_Update"">Url Download</label>
							");
                WriteLiteral(@"<input type=""text"" class=""form-control"" id=""UrlDownload_Update"" name=""UrlDownload"" placeholder=""Enter Url Download""/>
						</div>

						<div class=""form-group col-lg-4 col-md-6"">
							<label for=""Note_Update"">Note</label>
							<input type=""text"" class=""form-control"" id=""Note_Update"" name=""Note"" placeholder=""Enter Note""/>
						</div>
						
						<div class=""m-2 col-sm-12 text-center"">
							<button type=""button"" id=""form_update_close"" class=""btn btn-danger"">Close</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>

// Definition

var baseUrl = ""https://localhost:44310/api/"";
var itemList = [];
var selectedItem = null;
var selectedIndex = -1;

var getAllItems = function() {

	$(""#table_items"").show();
    $(""#loading"").show();

	$.get(baseUrl + ""Books"", function(data, status)
	{
        if (status == ""success"") {
			$(""#loading"").hide(0.5);
            itemList = data;
            console.log(itemList);
            renderItems(itemList);
        }
        else {
            alert(data);
		}
	});

}

var renderItems = function(dataset) {
            
    let dataRow = """";
	
	dataset.forEach((item, idx) => {
        dataRow += 
		`
		<tr id=""${item.id}"">
			<td>${item.id}</td>
			<td>${item.title}</td>
			<td>${item.type.name}</td>
			<td>${item.urlDownload}$</td>
			<td>${item.publisher.name}</td>
			<td>${item.note}</td>
			<td>
				<button name=""btn-update"" class=""btn btn-success m-1"" value=""${idx}"">Edit</button>
				<button name=""btn-delete"" class=""btn btn-dang");
                WriteLiteral(@"er m-1"" value=""${idx}"">Remove</button>
			</td>
		<tr>
		`;
    });

    $(""#table_items tbody"").html(dataRow);
    addFillDataEvent();

}

var addFillDataEvent = () => {
	$(""button[name='btn-update']"").click(updateBtnClicked);
	$(""button[name='btn-delete']"").click(deleteBtnClicked);
}

var updateBtnClicked = (e) => {

    console.log(""update clicked!"");
    let idx = e.currentTarget.value;
    selectedItem = itemList[idx];
    selectedIndex = idx;

    fillInfo(selectedItem);

	$(""#form_update"").show(0.8);
    $(""#form_create"").hide(0.8);
}

var fillInfo = function(item) {
    $(""#Id_Update"").val(item.id);
    $(""#Title_Update"").val(item.title);
    $(""#Type_Update"").val(item.type.id);
    $(""#Publisher_Update"").val(item.publisher.id);
    $(""#UrlDownload_Update"").val(item.urlDownload);
    $(""#Note_Update"").val(item.note);
};

var deleteBtnClicked = (e) => {
	console.log(""delete clicked!"");
            
	let idx = e.currentTarget.value;
	let deleteSelectedItem = ite");
                WriteLiteral(@"mList[idx];
    console.log(idx);
    console.log(deleteSelectedItem);
    if (confirm(`Delete author with Id=${deleteSelectedItem.id}? You cannot reverse data!`)) {
				
		$.ajax({
		type: 'delete',
        headers: {
			""Content-Type"": ""application/json""
		},
		url: baseUrl + ""Books"" + ""/"" + deleteSelectedItem.id,
		success: function () {
			alert('Request was successful.');
            if (deleteSelectedItem === selectedItem) {
				selectedItem = null;
				selectedIndex = -1;
			}
            $(`#${deleteSelectedItem.id}`).hide(1);
		},
		error: function (err) {
			alert('An error occurred: ' + err.responseText);
			console.log(err.responseText);
		},
	});
	}
}

var getOptions = function(endpoint, DOM) {

	$.get(baseUrl + ""AppTypes/"" + endpoint, function(data, status)
	{
        if (status == ""success"") {
            console.log(data);
            filloptionsToSelectBox(DOM, data);
        }
        else {
            alert(data.responseText);
		}
	});
}

var fillop");
                WriteLiteral(@"tionsToSelectBox = function(DOM, dataset) {
    
	let dataRow = """";

	dataset.forEach((option, idx) => {
        dataRow += 
		`
		<option value=${option.id}>${option.name}</option>
		`;
    });

    DOM.append(dataRow);
}

$(""#btn-refresh"").click(getAllItems);

$(""#form_update_close"").click(() => {
    $(""#form_update"").hide(1);
})

$(""#btn-create"").click(() => {

	$(""#form_create"").show(1);
});

$(""#form_create_close"").click(() => {
    $(""#form_create"").hide(1);
})

var Init = function() {
	$(""#loading"").hide();
    $(""#table_items"").hide();
    $(""#form_update"").hide();
    $(""#form_create"").hide();

    getAllItems();
    getOptions(""GetBookTypes"", $(""select[name='Type']""));
    getOptions(""GetPublishers"", $(""select[name='PublisherId']""));
}();

// create publisher use ajax
var frm = $('#form_create');
frm.submit(function (e) {
	// don't submit form yet
	e.preventDefault();

    var object = {};
	// get value from form stackoverflow
	(new FormData(e.target)");
                WriteLiteral(@").forEach(function(value, key){
		// check can parse from string to int or not
		if(!isNaN(value)){
			value = parseFloat(value);
		}
		object[key] = value;
	});

	var json = JSON.stringify(object);

    console.log(""Submit(post): "" + json);

	$.ajax({
		type: 'post',
        headers: {
			""Content-Type"": ""application/json""
		},
		url: baseUrl + ""Books"",
		data: json,
		// onsuccess
		success: function (item) {
			alert('Create publisher was successful, Id=' + item.id);
				console.log(item);
		},
		// onerror
		error: function (err) {
			alert('An error occurred: ' + err.responseText);
			console.log(err.responseText);
		},
	});
});


// update publisher use ajax
var updateFrm = $('#form_update');
updateFrm.submit(function (e) {
	// don't submit form yet
	e.preventDefault();

	var object = {};
	// get value from form stackoverflow
	(new FormData(e.target)).forEach(function (value, key) {
		// check can parse from string to int or not
		if (!isNaN(value)) {
			value");
                WriteLiteral(@" = parseFloat(value);
		}
		object[key] = value;
	});

	var json = JSON.stringify(object);

	console.log(""Submit(put): "" + json);

	$.ajax({
		type: 'put',
		headers: {
			""Content-Type"": ""application/json""
		},
		url: baseUrl + ""Books"",
		data: json,
		// onsuccess
		success: function (item) {
			alert('Update publisher was successful, Id=' + item.id);
			console.log(item);

			let newRow =
				`
				<tr id=""${item.id}"">
					<td>${item.id}</td>
					<td>${item.title}</td>
					<td>${item.type.name}</td>
					<td>${item.urlDownload}$</td>
					<td>${item.note}</td>
					<td>
						<button name=""btn-update"" class=""btn btn-success m-1"" value=""${idx}"">Edit</button>
						<button name=""btn-delete"" class=""btn btn-danger m-1"" value=""${idx}"">Remove</button>
					</td>
				<tr>
				`;
			$(`#${item.id}`).replaceWith(newRow); 
			itemList[selectedIndex] = item;
			addFillDataEvent();
		},
		// onerror
		error: function (err) {
			alert('An error occurred: ' + err.responseText)");
                WriteLiteral(";\r\n\t\t\tconsole.log(err.responseText);\r\n\t\t},\r\n\t});\r\n});\r\n\r\n</script>\r\n\r\n");
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
