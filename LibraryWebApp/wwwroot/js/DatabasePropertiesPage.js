function onClickedAddNewCategory()
{
    $("#AddNewCategoryPopup").modal("show");
}

function onClickedEditCategory(id, valuem) {

    var categoryIdInputField = document.getElementById("categoryIdInputField");
    categoryIdInputField.value = id;

    var categoryInputField = document.getElementById("categoryField");
    categoryInputField.value = valuem;


    $("#EditExistingCategoty").modal("show");
}



function onClickedAddNewAuthor() {
    $("#AddNewAuthorPopup").modal("show");
}

function onClickedEditAuthor(id, valuem) {

    var categoryIdInputField = document.getElementById("authorIdInputField");
    categoryIdInputField.value = id;

    var categoryInputField = document.getElementById("authorField");
    categoryInputField.value = valuem;


    $("#EditExistingAuthor").modal("show");
}


function x() {
    $.ajax({
        type: "GET",
        url: '@Url.Action("UpdateDatabasEditeProperties", "Edit")',
        data: { id: id },
    }).done(function (msg) {
        if (msg.status === 'added') {
            $('#favarite-user').load(' #favarite-user')
        }
    });
}
