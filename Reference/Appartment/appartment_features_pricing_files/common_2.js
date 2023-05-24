    function get(element){
        return document.getElementById(element).value;
    }
    function set(message,element){
        document.getElementById(element).innerHTML = message;
    }
    function setError(element){
        text = document.getElementById(element).innerHTML;
        set('<font color="RED">'+text+'</font>',element);
    }
    function reset(element){
        text = document.getElementById(element).innerHTML;
        if(text.indexOf("RED")!=-1){
            textBegin = text.indexOf(">")+1;
            textEnd=text.indexOf("</font");
            newText = text.substr(textBegin,textEnd-6);
            set(newText,element);
        }
        return true;
    }

    function redirect(target){
        window.location = target;
    }

    function check_email(str) {
        if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/.test(str))
            return true;
        else
            return false;
    }

function NewWindow(mypage,myname,w,h,pos,infocus){
//var win=null;
//
var pos = "center";
if(pos=="random"){myleft=(screen.width)?Math.floor(Math.random()*(screen.width-w)):100;mytop=(screen.height)?Math.floor(Math.random()*((screen.height-h)-75)):100;}
if(pos=="center"){myleft=(screen.width)?(screen.width-w)/2:100;mytop=(screen.height)?(screen.height-h)/2:100;}
    else if((pos!='center' && pos!="random") || pos==null){myleft=0;mytop=20}
settings="width=" + w + ",height=" + h + ",top=" + mytop + ",left=" + myleft + ",scrollbars=yes,location=no,directories=no,status=no,menubar=no,toolbar=no,resizable=no";
win=window.open(mypage,'AddaPopUp',settings);
win.focus();
/*day = new Date();
id = day.getTime();
window.open(mypage, 'AddaPopUp', 'toolbar=0,scrollbars=1,location=0,statusbar=1,menubar=0,resizable=1,width='+w+',height='+h+',left = myleft,top = mytop');*/    
}

String.prototype.trim = function() {
	return this.replace(/^\s+|\s+$/g,"");
}

function viewResident(residentId){
   NewWindow('../modules/residents_list_view.php?resident_id='+residentId,"AddaPopUp","400","300","center","");
}

//checks all checkboxes
function checkAll(elements) {
     for (i = 0; i < elements.length; i++) {
       if (elements[i].type == "checkbox") {
         elements[i].checked = true;
       }
     }
}

//unchecks all checkboxes
function uncheckAll(elements) {
    for (i = 0; i < elements.length; i++) {
      if (elements[i].type == "checkbox") {
        elements[i].checked = false;
      }
    }
}

function nl2br(text){
    return text.replace(/\n/g,'<br/>');
}

function buzzar_cancel() {
    document.location.href = "index.php";
}

function go_back(uri, quote_id) {
    document.location.href = uri + "?quote=" + quote_id;
}

