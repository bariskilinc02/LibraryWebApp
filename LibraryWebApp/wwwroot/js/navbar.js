function expandNavbar() {
    var expandableContent = document.getElementById("expandableNavbar");
    var buttonParent = document.getElementById("navbar_buttons_parent");




    if (expandableContent.classList.contains("navbar_show")) {
        buttonParent.classList.remove("on_opened_bar_button_container_status");
        buttonParent.classList.add("on_closed_bar_button_container_status");
        buttonParent.classList.toggle("on_closed_bar_button_container_status", true);

        expandableContent.classList.remove("navbar_show");
        expandableContent.classList.add("navbar_hidden");
        expandableContent.classList.toggle("navbar_hidden", true);
    }
    else {
        buttonParent.classList.remove("on_closed_bar_button_container_status");
        buttonParent.classList.add("on_opened_bar_button_container_status");
        buttonParent.classList.toggle("on_opened_bar_button_container_status", true);

        expandableContent.classList.remove("navbar_hidden");
        expandableContent.classList.add("navbar_show");
        expandableContent.classList.toggle("navbar_show", true);
    }

}

function collapseNavbar() {

    var expandableContent = document.getElementById("expandableNavbar");

    if (expandableContent.classList.contains("navbar_hidden")) {
        expandableContent.classList.remove("navbar_show");
        expandableContent.classList.remove("navbar_hidden");
        expandableContent.classList.add("navbar_hidden");
    }
}

function navbarClicked() {
    //var coll = document.getElementsByClassName("expandableNavbar");
    //var i;

    var expandableContent = document.getElementById("expandableNavbar");

    if (expandableContent.classList.contains("navbar_show")) {
        expandableContent.classList.remove("navbar_show");
        expandableContent.classList.add("navbar_hidden");
    }
    else {
        expandableContent.classList.add("navbar_show");
        expandableContent.classList.remove("navbar_hidden");
    }
}

var togView = document.querySelectorAll('.expander');

togView.forEach((button) => {
    button.addEventListener('click', () => {
        expandNavbar();
    });
});

function Logout() {
    $.ajax({
        url: '/Auth/Logout',
        async: true,
        success: function (data) {
            // Çıkış işlemi başarılı olduğunda yapılacak işlem
            window.location.href = "/"; // Tarayıcıyı "Index" sayfasına yönlendir
        }
      
    });

}

function LogoutAdmin() {
    $.ajax({
        url: '/Admin/Home/LogoutAdmin',
        async: true,
        success: function (data) {
            
            // Çıkış işlemi başarılı olduğunda yapılacak işlem
            window.location.href = "/"; // Tarayıcıyı "Index" sayfasına yönlendir
        }

    });

}