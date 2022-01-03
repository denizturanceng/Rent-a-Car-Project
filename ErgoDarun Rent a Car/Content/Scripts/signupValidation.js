var form = document.querySelector('.needs-validation');

form.addEventListener('submit', function (event) {
    if (form.checkValidity() === false) {
        event.preventDefault();
        event.stopPropagation();
        alert("Lütfen tüm boşukları doğru doldurduğunuzdan emin olunuz.");
    }
    else {
        alert("Kullanıcı kaydı tamamlanmıştır.")
    }
    form.classList.add('was-validated');
})
