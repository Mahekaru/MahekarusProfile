//<div class="col-sm-4 col-md-4">
//    <h2>Basic CRUD App</h2>
//    <p>An Web App to showcase CRUD using Entity Framework</p>
//    <img style="height:153px;width:350px" class="img-fluid" src="~/img/Entity Framework.png" />
//    <a href="https://github.com/MichaelEJennings/Basic-CRUD" target="_blank">github Link</a>
//    <p>@Html.ActionLink("Open App", "Index", "GameDatas", null, new { @class = "btn btn-secondary" })</p>
//</div>

//addApp("Basic CRUD App", "A Web App to showcase CRUD using Entity Framework", "/img/Entity Framework.png", "https://github.com/MichaelEJennings/Basic-CRUD", "Action LINK");


function addApp(appName, appDescription, imgName,gitHubLink,actionLinkData) {
    var appGroup = document.getElementById("app-Group");
    //myList.style.overflow = "Auto";

    var newdiv = document.createElement("div");
    newdiv.classList.add("col-sm-4");
    newdiv.classList.add("col-md-4");

    var h2AppName = document.createElement("h2");
    h2AppName.innerText = appName;

    var pAppDesc = document.createElement("p");
    pAppDesc.innerText = appDescription;

    var appimg = document.createElement("img");
    appimg.style.height = "153px";
    appimg.style.width = "350px";
    appimg.classList.add("img-fluid");
    appimg.src = imgName;

    var gitLink = document.createElement("a");
    gitLink.href = gitHubLink;
    gitLink.target = "_blank";
    gitLink.innerText = "Github Link";

    //var AL = document.
    //    "@Html.ActionLink('Open App', 'Index', 'GameDatas', null, new { @class = 'btn btn - secondary' })";

    var all = "@Html.ActionLink('Open App', 'Index', 'GameDatas', null, new { @class = 'btn btn - secondary' })";

    newdiv.appendChild(h2AppName);
    newdiv.appendChild(pAppDesc);
    newdiv.appendChild(appimg);
    newdiv.appendChild(gitLink);
    newdiv.appendChild(AL);

    appGroup.appendChild(newdiv);

}