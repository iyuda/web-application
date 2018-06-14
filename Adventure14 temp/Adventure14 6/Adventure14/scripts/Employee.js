

function SearchMe(comboID) {

    var combo = document.getElementById(comboID);
    var tdbox = document.getElementById("ContentPlaceHolder1_lblMessage");
    var searchbox = document.getElementById("ContentPlaceHolder1_txtSearch");

    //for (i = 0; i < document.forms[0].elements.length; i++) {

    //    if (document.forms[0].elements[i].id.indexOf("lblMessage") > -1) {
    //        tdbox = document.forms[0].elements[i];
    //        break;
    //    }
    //}

    if (combo.value == "-1") {

        tdbox.className = "cellError";
        tdbox.innerHTML = "-- Please select Department name."
        return false;
    }
    else
    {
        tdbox.className = "";
        tdbox.innerHTML = "";
        searchbox.value = combo.value;
        document.forms[0].submit();
        return true;
    }
 
}