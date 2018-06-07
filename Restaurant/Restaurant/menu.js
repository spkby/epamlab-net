function toByn(price) {
    return parseInt(price / 100) + "." + parseInt(price / 10 % 10) + parseInt(price % 10)
}

var accItem = $('.menuItem');

var accHD = $('.menuItemHeading');

for (i = 0; i < accHD.length; i++) {
    accHD[i].addEventListener('click', toggleItem, false);
}

function getItems(id) {
    var request = new XMLHttpRequest();

    request.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var items = JSON.parse(this.responseText);
            items.forEach(element => {
                $('#' + id).append('<h2>' + element.Dishname + '</h2>' + '<p>' + element.Desc + '</p>' + '<p>' + toByn(element.Price) + ' BYN</p>');
            });
        }
    };

    request.open('GET', '/Home/GetItems/' + id);
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