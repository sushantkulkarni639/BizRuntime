var Hello = Hello || {};
Hello.TeamBB = Hello.TeamBB || {};

Hello.TeamBB.Customer = function(firstName, middleName, lastName) {
    this.firstName = firstName;
    this.middleName = middleName;
    this.lastName = lastName;
    this.getFullName = function () {
        return this.firstName + " " + this.middleName + " " + this.lastName;
    }
    return this;
}