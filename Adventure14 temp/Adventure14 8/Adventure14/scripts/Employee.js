

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

function ClickTheLink() {
    //location.href = "http://www.google.com"
    window.open("http://www.google.com");
}
