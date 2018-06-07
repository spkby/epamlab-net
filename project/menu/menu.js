
var accItem = $('.menuItem');

var accHD = $('.menuItemHeading');

for (i = 0; i < accHD.length; i++) {
    accHD[i].addEventListener('click', toggleItem, false);
}

function toggleItem() {
    var itemClass = this.parentNode.className;

    for (i = 0; i < accItem.length; i++) {
        accItem[i].className = 'menuItem close';
    }

    if (itemClass == 'menuItem close') {
        this.parentNode.className = 'menuItem open';

        var id = 0;

        for (i = 0; i < accItem.length; i++) {
            if (accItem[i].className == 'menuItem open') {
                id = i;
            }
        }

        $('#'+id).text("<p>Test" + id + "</p>");

    }
}