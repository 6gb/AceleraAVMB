/*
fetch('section.html').then((resp) => resp.text()).then(function(data) {
        document.getElementsByTagName("section").innerHTML = data;
    });
*/

/*
var xhr= new XMLHttpRequest();
xhr.open('GET', 'section.html', true);
xhr.onreadystatechange = function() {
    if (this.readyState!==4) return;
    if (this.status!==200) return; // or whatever error handling you want
    document.getElementsByTagName('section')[0].innerHTML= this.responseText;
};
xhr.send();
*/