var accItem = $('.menuItem');

var accHD = $('.menuItemHeading');

for (i = 0; i < accHD.length; i++) {
    accHD[i].addEventListener('click', toggleItem, false);
}

function getItems(id) {

    var request = new XMLHttpRequest();
    request.open('GET', 'http://localhost:5000/Home/Contact', true);
    request.onreadystatechange = function () {
        if (this.readyState == 4) {
            if (this.status == 200 || this.status == 0) {
                alert(this.responseText)
                $('#' + id).append("<p>" + obj.name + "</p>")
            }
            else alert('Error: ' + this.statusText)
        }
    };
    request.send();
}

function toggleItem() {
    var itemClass = this.parentNode.className;

    for (i = 0; i < accItem.length; i++) {
        $('#' + i).empty();
        accItem[i].className = 'menuItem close';
    }

    if (itemClass == 'menuItem close') {
        this.parentNode.className = 'menuItem open';

        var id = 0;

        for (i = 0; i < accItem.length; i++) {
            if (accItem[i].className == 'menuItem open') {
                getItems(i);
            }
        }
    }
}