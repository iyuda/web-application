/// <reference path="E:\ProjectNet\Adventure14\Adventure14\Views/PopUp/EmployeeDetails.aspx" />
/// <reference path="E:\ProjectNet\Adventure14\Adventure14\Views/PopUp/EmployeeDetails.aspx" />

var win;

function SearchMe(comboID) {
   
    var combo = document.getElementById(comboID);
    //var tdbox = document.getElementById("ContentPlaceHolder1_lblMessage");  //- Workable, but not advisable.
    var tdbox = document.getElementById(id_Message);
    //var tdbox = document.getElementById('<%=lblMessage.ClientID%>');   //- Won't work.  JS file does not see C# objects.
    var hideParam;

    for (i = 0; i < document.forms[0].elements.length; i++) {

        if (document.forms[0].elements[i].id.indexOf("txtParam") > -1) {
            hideParam = document.forms[0].elements[i];
            break;
        }
    }

    if (combo.value == "-1") {
        hideParam.value = "";
        tdbox.className = "cellError";
        tdbox.innerHTML = "-- Please select Department name."
        return false;
    }
    else
    {
        tdbox.className = "";
        tdbox.innerHTML = "";
        //hideParam.value = "Search:" + combo.value;
        //document.forms[0].submit();
        return true;
    }
 
}

function ClearData(cntrlID) {

    var cntrl = document.getElementById(cntrlID);

    if(cntrl != null)
    {
        cntrl.value = "";
    }

}

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
