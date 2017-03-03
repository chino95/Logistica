$(document).ready(function () {
    validarLogin();
});


function login() {
    var datos = {
        user: $('#txtU').val(),
        pass: $('#txtP').val()
    };

    $.ajax({
        url: 'Default.aspx/UserLogin',
        type: 'POST',
        contentType: "application/json",
        data: JSON.stringify(datos),
        dataType: 'json',
        success: function (r) {
            if (r.d == -1)
                notificar("error", "Usuario y/o contraseña inválidos");
            else
                document.location.replace("../Admin/Clientes.aspx");
            $('.login-form')[0].reset();
        },
        error: function () {
            alert('Ocurrio un Error');
        }
    });
}


function validarLogin() {
    $('.login-form').validate({
        errorElement: 'span', //default input error message container
        errorClass: 'help-block', // default input error message class
        focusInvalid: false, // do not focus the last invalid input
        rules: {
            nombre: {
                required: true
            },
            psw: {
                required: true
            },
            correo: {
                required: true
            },
            celular: {
                required: true
            },
            repsw: {
                equalTo: "#psw"
            }
        },

        messages: {
            nombre: {
                required: "Favor de Ingresar su Nombre."
            },
            psw: {
                required: "Favor de Ingresar Contraseña."
            },
            correo: {
                required: "Favor de Ingresar su Nombre."
            },
            celular: {
                required: "Favor de Ingresar Contraseña."
            }
        },

        invalidHandler: function (event, validator) { //display error alert on form submit   
            $('.alert-danger', $('.login-form')).show();
        },

        highlight: function (element) { // hightlight error inputs
            $(element)
                .closest('.form-group').addClass('has-error'); // set error class to the control group
        },

        success: function (label) {
            label.closest('.form-group').removeClass('has-error');
            label.remove();
        },

        errorPlacement: function (error, element) {
            error.insertAfter(element.closest('.input-icon'));
        },

        submitHandler: function (form) {
            login();
        }
    });
}