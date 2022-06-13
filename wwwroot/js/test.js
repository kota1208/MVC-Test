console.log("Piyo");

function checkRangeAge() {
    let result = window.confirm("送信しますか");
    if (result == true) {
        document.inputForm.submit();
    } else {

    }
    
    let name = document.getElementById("name");
    alert("名前->" + name.value);
}