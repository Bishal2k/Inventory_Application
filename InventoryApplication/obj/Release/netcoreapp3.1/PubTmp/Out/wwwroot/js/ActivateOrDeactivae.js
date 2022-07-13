var alertText;
var href;
var buttonNameAfterOperation;
$('.Deactivate').click(function (evt) {
    href = $(this).attr('href');
    buttonNameAfterOperation = "Activate"
    alertText = " Please Check all the item?!!!!"
    evt.preventDefault();
    fireSwal();
});
//$('.Activate').click(function (evt) {
//    href = $(this).attr('href');
//    buttonNameAfterOperation = "Deactivate"
//    alertText = " You want to activate the group?!!!"
//    evt.preventDefault();
//    fireSwal();
//});


function fireSwal() {
    Swal.fire({
        title: 'Are you sure?',
        text: alertText,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then((result) => {
        if (result.isConfirmed) {
            window.location = href;
        }
    })
}