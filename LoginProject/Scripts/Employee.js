function LoginValidation() {
    var errorMsg = "";
    var errorFlag = true;
    const focusBox = [];

    if (document.getElementById('txtUsername').value.trim().length == 0) {
        errorMsg += " Username,";
        focusBox.push("txtUsername");
        errorFlag = false;
    }

    if (document.getElementById('txtPassword').value.trim().length == 0) {
        errorMsg += " Password,";
        focusBox.push("txtPassword");
        errorFlag = false;
    }

    if (errorMsg != "") {
        alert("Required fields *" + errorMsg.slice(0, -1));
        document.getElementById(focusBox[0]).focus();
        errorFlag = false;
    }

    return errorFlag;
}

//Validating the all the text fields Create Employee

function AddEmployeeValidation() {

    var errorMsg = "";
    var errorFlag = true;
    const focusBox = [];

    if (document.getElementById('txtFirstName').value.trim().length == 0) {
        errorMsg += " First Name,";
        focusBox.push("txtFirstName");
        errorFlag = false;
    }
  
    if (document.getElementById('txtLastName').value.trim().length == 0) {
        errorMsg += " Last Name,";
        focusBox.push("txtLastName");
        errorFlag= false;
    }

    if (document.getElementById('txtEmail').value.trim().length == 0) {
        errorMsg += " Email,";
        focusBox.push("txtEmail");
        errorFlag= false;
    }

    if (document.getElementById('txtDepartment').value == '0') {
        errorMsg += " Department,";
        focusBox.push("txtDepartment");
        errorFlag= false;
    }

    if (document.getElementById('txtDate').value == '') {
        errorMsg += " Date of Birth,";
        focusBox.push("txtDate");
        errorFlag= false;
    }

    if (document.getElementById('txtSalary').value.trim().length == 0) {
        errorMsg += " Salary,";
        focusBox.push("txtSalary");
        errorFlag= false;
    }

    if (document.getElementById('txtAddress1').value.trim().length == 0) {
        errorMsg += " Address 1,";
        focusBox.push("txtAddress1");
        errorFlag= false;
    }

    if (document.getElementById('txtAddress2').value.trim().length == 0) {
        errorMsg += " Address 2,";
        focusBox.push("txtAddress2");
        errorFlag= false;
    }

    if (errorMsg != "") {
        alert("Required fields *" + errorMsg.slice(0,-1));
        document.getElementById(focusBox[0]).focus();
        errorFlag = false;
    }

    if (ValidateEmail() == false && document.getElementById('txtEmail').value.trim().length != 0) {
        alert('Email is Incorrect!.');
        document.getElementById('txtEmail').focus();
        errorFlag = false;
    }


    var enteredAge = getAge(document.getElementById('txtDate').value);
    if (enteredAge < 18 && document.getElementById('txtDate').value.trim().length != 0) {
        alert("Age should be above 18 years!.");
        document.getElementById('txtDate').focus();
        errorFlag = false;
    }

    
    if (checkSalay() == false && document.getElementById('txtSalary').value.trim().length != 0) {
        alert('Incorrect Salary Value!.');
        document.getElementById('txtSalary').focus();
        errorFlag = false
    }

    return errorFlag;
}

//function CreateValidate() {
//    var errorFlag = true;
//    if (chkValidations()) {
//        errorFlag = true;
//    }
//    else {
//        errorFlag = false;
//    }
//    return errorFlag;
//}



//Validation of email
function ValidateEmail() {
    var email = document.getElementById('txtEmail');
    var filter = /^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/;
    if (!filter.test(email.value)) {
        return false;
    }
    return true;
}

//validation of date of birth
function getAge(DOB) {
    var today = new Date();
    var dateParts = DOB.split('-');
    var birthYear = dateParts[2];
    var birthMonth = parseInt(dateParts[1])-1;
    var birthDay = dateParts[0];
    var birthDate = new Date(birthYear, birthMonth, birthDay);
    var ageDifference = parseInt(today.getFullYear()) - parseInt(birthDate.getFullYear());6

    if (isNaN(ageDifference))
        return 0;
    return ageDifference;
}

//Validation of salary 
function checkSalay() {
    var sal = document.getElementById('txtSalary').value;
    var allowedString = /^\d+(\.\d{0,2})?$/; // Allow 2 decimal place with numeric value
    if (allowedString.test(sal) == false) {
        return false;
    }
    return true;
}

//Alert method for delete 
function alertForDelete() {
    let text = "Are you sure!, Do you want to delete the emploee record?";
    if (confirm(text) == true) {
        return true;
    } else {
        return false;
    }
}


