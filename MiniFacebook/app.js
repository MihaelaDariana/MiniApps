var database = [
    {
        username: "andrei",
        password: "supersecret"
    },
    {
        username: "marcelina",
        password: "numelecainelui"
    },
    {
        username: "paginaSponsorizata",
        password: "parola123"
    }
];

const buton1 = document.querySelector('.btnSubmit');
buton1.addEventListener('click', signIn);

const buton2 = document.querySelector('.btnShow');
buton2.addEventListener('click', showDiv);

const buton3 = document.querySelector('.btnAdd');
buton3.addEventListener('click', addUser);

function signIn() {
    var usernameInput = document.getElementById("user").value;
    var passwordInput = document.getElementById("pass").value;
    if (isUserValid(usernameInput, passwordInput)) {
        window.location.href = "http://127.0.0.1:5500/MiniFacebook/feed.html"

    }
    else {
        alert("Wrong username or password");
    }
}

function isUserValid(username, password) {
    for (var i = 0; i < database.length; i++) {
        if (database[i].username === username && database[i].password === password) {
            return true;
        }


    }
    return false;
}

function showDiv(){
    var rDiv=document.getElementById("registerForm")
    if (rDiv.style.display === "none") {
        rDiv.style.display = "block";
      } else {
        rDiv.style.display = "none";
      }
}

function addUser() {
    var nuser = document.getElementById("nuser").value;
    var npass = document.getElementById("npass").value;
   var nElement={}; //create a new element for the database and then put the artibutes
   nElement.username=nuser;
   nElement.password=npass;
   database.push(nElement);
    
}
