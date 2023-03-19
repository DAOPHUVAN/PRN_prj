// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var BookRenderer = (book, idx) => `
    <div class="col-md-6 col-lg-4" onClick=click1(${book.id}) >
		<div class="card" style="max-width: 18rem;">
				<img src="https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fGJvb2t8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60"
					class="card-img-top" height="220" alt="${book.title}">
				<div class="card-body">
					<h5 class="card-title">${book.title}</h5>
					<div class="d-flex justify-content-between">
						<small>${book.type.name}</small>
					</div>
					<p class="card-text">${book.note}</p>
				</div>
		</div>
	</div>
    `;

function click1(id) {
	window.location.href = "https://localhost:44373/Home/detail/"+id 
}