// wwwroot/js/login.js
document.getElementById("loginButton").addEventListener("click", function () {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    var loginMessage = document.getElementById("loginMessage");

    // Clear any previous messages
    loginMessage.innerHTML = "";

    // Check if the username and password fields are not empty
    if (username === "" || password === "") {
        loginMessage.innerHTML = "Please fill in both fields.";
        return;
    }

    // Send the AJAX request
    fetch("/Home/VerifyLogin", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            username: username,
            password: password
        })
    })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                // If login is successful, redirect to the next page
                window.location.href = "/Dashboard/Dashboard";
            } else {
                // Display failure message
                loginMessage.innerHTML = "Invalid username or password.";
            }
        })
        .catch(error => {
            console.error("Error during login:", error);
            loginMessage.innerHTML = "An error occurred. Please try again.";
        });
});
