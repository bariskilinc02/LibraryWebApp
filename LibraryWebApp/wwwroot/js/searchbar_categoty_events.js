function mytoggleDropdown() {
	var dropdownContent = document.getElementById("dropdownContent");

/*	dropdownContent.style.display = (dropdownContent.style.display == "inline-grid") ? "none" : "inline-grid";*/
	var expandableContent = document.getElementById("category_dropdown_button");

	if (expandableContent.classList.contains("category_dropdown_show")) {
/*		dropdownContent.style.display = "none";*/

		dropdownContent.classList.remove("dropdown-content-show");
		dropdownContent.classList.add("dropdown-content-hide");
		dropdownContent.classList.toggle("dropdown-content-hide", true);

		expandableContent.classList.remove("category_dropdown_show");
		expandableContent.classList.add("category_dropdown_hide");
		expandableContent.classList.toggle("category_dropdown_hide", true);
	}
	else
	{
		/*dropdownContent.style.display = "inline-grid";*/

		dropdownContent.classList.remove("dropdown-content-hide");
		dropdownContent.classList.add("dropdown-content-show");
		dropdownContent.classList.toggle("dropdown-content-show", true);

		expandableContent.classList.remove("category_dropdown_hide");
		expandableContent.classList.add("category_dropdown_show");
		expandableContent.classList.toggle("category_dropdown_show", true);
	}



}

function selectCategory(categoryId) {
	var selectedCategory = document.querySelector(".category_button");
	var dropdownContent = document.getElementById("dropdownContent");

	switch (categoryId) {
		case 1:
			selectedCategory.textContent = "Tarih";
			break;
		case 2:
			selectedCategory.textContent = "Yıl";
			break;
		default:
			selectedCategory.textContent = "Hepsi";
			break;
	}

	document.getElementById('selectedCategory').value = categoryId;
	mytoggleDropdown();
	// Kategoriyi seçtikten sonra dropdown'u kapat
/*	dropdownContent.style.display = "none";*/
}