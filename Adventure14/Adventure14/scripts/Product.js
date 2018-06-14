function ClickTheLink(emplID) {
    //location.href = "http://www.google.com"
    //window.open("http://www.google.com");
    //window.open('http://www.google.com', '_blank', 'toolbar=0,location=0,menubar=0');
   
    if (win != null) { win.close();}
    win = window.open('PopUp/EmployeeDetails.aspx?emplID=' + emplID, '_blank', 'toolbar=0, location=0, menubar=0, width=350,height=300');
    if (win != null)
    {
        win.moveTo(800, 400);
        win.focus();
    }
    return false;
}
function UserWelcome(userName) {
    alert("Hello");
  //  if (win != null) { win.close(); }
    alert("sadfasd");
    win = window.open('PopUp/EmployeeDetails.aspx?emplID=' + emplID, '_blank', 'toolbar=0, location=0, menubar=0, width=350,height=300');
    alert("win");
    if (win != null) {
        alert("not null");
        win.moveTo(800, 400);
        win.focus();
        
    }
    else
        alert("bull");
    //if (win != null) {
    //    win.moveTo(800, 400);
    //    win.focus();
    //}
    return false;

}