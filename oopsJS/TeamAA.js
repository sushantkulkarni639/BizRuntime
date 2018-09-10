var Hello = Hello || {};
Hello.TeamAA = Hello.TeamAA || {};

Hello.TeamAA.Customer=function(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.getFullName = function () {
        return this.firstName + " " + this.lastName;
    }
    return this;
}
// here Hello wil b added to global namespaces
// in js window is the alias name for global namespace 