var newsfeed = [
	{
		username: "Bobby",
		timeline: "So tired from all that learning!"
	},
	{
		username: "Sally",
		timeline: "Javascript is sooooo cool!"
	},
	{
		username: "Mitch",
		timeline: "Javascript is preeetyy cool!"
	}
];

for(var i=0;i<newsfeed.length;i++){
    const newDivUser=document.createElement("div");
    newDivUser.setAttribute("id","usernameDiv");
    const newDivTimeline=document.createElement("div");
    newDivTimeline.setAttribute("id","timeline");
    const newUser=document.createTextNode(newsfeed[i].username);
    const newTimeline=document.createTextNode( " Posted: "+newsfeed[i].timeline);
    newDivUser.appendChild(newUser);
    newDivTimeline.appendChild(newTimeline);
    const currentDiv=document.getElementById("feedContainer");
    currentDiv.appendChild(newDivUser);
    currentDiv.appendChild(newDivTimeline);

}

const butonOut=document.querySelector('.bo');
butonOut.addEventListener('click',signOut);

const butonNewPost=document.querySelector('.bn');
butonNewPost.addEventListener('click',newPost);

const butonAddPost=document.querySelector('.bap');
butonAddPost.addEventListener('click',addPost);

function signOut(){
    window.location.href="http://127.0.0.1:5500/MiniFacebook/index.html"
}

function addPost(){
    var nuser = document.getElementById("userpost").value;
    var npost = document.getElementById("timelinepost").value;
   var nElement={}; //create a new element for the database and then put the artibutes
   nElement.username=nuser;
   nElement.timeline=npost;
   newsfeed.push(nElement);
   
   const newDivUser=document.createElement("div");
    newDivUser.setAttribute("id","usernameDiv");
    const newDivTimeline=document.createElement("div");
    newDivTimeline.setAttribute("id","timeline");
    const newUser=document.createTextNode(nElement.username);
    const newTimeline=document.createTextNode( " Posted: "+nElement.timeline);
    newDivUser.appendChild(newUser);
    newDivTimeline.appendChild(newTimeline);
    const currentDiv=document.getElementById("feedContainer");
    currentDiv.appendChild(newDivUser);
    currentDiv.appendChild(newDivTimeline);

}

function newPost(){
    var rDiv=document.getElementById("posts")
    if (rDiv.style.display === "none") {
        rDiv.style.display = "block";
      } else {
        rDiv.style.display = "none";
      }
}

