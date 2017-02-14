window.addEventListener("load", function (event) {

    /*===============
    Working On Slider
    =================*/
    var i = 0;
    var ImgArr = ["../Images/background.jpg", "../Images/i.jpg"];
    var Arrtex = ["Challenge Your Friends Now", "We Realy Provide A great Evalution for your Effort!!"];
    //get
    var img = document.getElementById("ImgSlid");
    var tex = document.getElementById("SlidText");
    //d0
    time = setInterval(function () {

        i++;
        if (i == ImgArr.length)
            i = 0;
        img.src = ImgArr[i];
        tex.textContent = Arrtex[i];
    }, 5000);
});