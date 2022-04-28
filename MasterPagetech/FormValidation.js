validateform = () => {
    var fname = document.getElementById("ContentWelocmePage_TxtFname").value;
    var lname = document.getElementById("ContentWelocmePage_TxtLname").value;
    var email = document.getElementById("ContentWelocmePage_TxtEmail").value;
    var password = document.getElementById("ContentWelocmePage_TxtPassword").value;
    var confpassword = document.getElementById("ContentWelocmePage_TxtConfirmPass").value;
    //var male = document.getElementsByName("ctl00$ContentWelocmePage$gender").value;
    if (fname == '' || lname == '' || email == '' || password == '' || confpassword == '') {
        alert('please enter all fields');
        return false  
    }
    
    let result = email.includes("@gmail.com")
    if (result) {

        if (password == confpassword) {
            return true
        }
        else {
            alert('the password is not match')
            return false;
        }
    } else {
        alert("enter valide gamil formate like @gmail.com");
        return false;
    }
   


    
   

}