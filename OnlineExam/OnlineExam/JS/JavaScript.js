window.addEventListener("load", function (event) {

    /*===============
    Working On Slider
    =================*/
    var i = 0;
    var ImgArr = ["../Images/slider_image_1.jpg", "../Images/slider_image_2.jpg"];
    var Arrtex = ["Challenge Your Friends Now", "We Realy Provide A great Evalution for your Effort!!"];
    //get
    var img = document.getElementById("ImgSlide");
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