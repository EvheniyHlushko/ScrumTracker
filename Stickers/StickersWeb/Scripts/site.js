$(document).ready(function () {

    function doDraggable() {
        $('#usersList li').css({ 'z-index': 100 }).draggable({
            'opacity': '0.5',
            'revert': true,
            'cursor': 'pointer'
        });
    }

    doDraggable();

    $(document).ajaxComplete(function () {
        doDraggable();
    });
    //$("#usersList li").draggable({ helper: 'clone' });

    // Gets All users 
    function getUsers() {
        var actionUrl = $('#GetUsers').val();
        //$("#users").load(actionUrl);
        $.ajax({
            type: 'GET',
            url: actionUrl,
            success: function (data) {
                $('#users').html(data);
            }
        });
    }
    //get all users in team
    function getUserTeamPos(idVal) {
        var actionUrl = $('#GetUserTeamPos').val();
        //$("#users").load(actionUrl);
        $.ajax({
            type: 'GET',
            url: actionUrl,
            data: { id: idVal },
            success: function (data) {
                $('#userTeamPos').html(data);
                $('#selectedTeam').val(idVal);
            }
        });
    }

    function addUserToTeam(idUser, idTeam) {
        var actionUrl = $('#AddUserToTeam').val();
        $.ajax({
            type: 'GET',
            url: actionUrl,
            data: { userId: idUser, teamId: idTeam },
            dataType: 'json',
            success: function (data) {
                if (data.Status === true) {
                    getUserTeamPos(data.InsertedId);
                }
                //alert(data.InsertedId);
            }
        });
    }

    function getTeamsByTerm(value, pageNumber) {
        var actionUrl = $('#GetTeamsByTerm').val();
        $.ajax({
            type: 'GET',
            url: actionUrl,
            data: { term: value, page: pageNumber },
            success: function(data) {
                $('#teams').html(data);
            }
        });
    }

    function getUsersByTerm(value) {
        var actionUrl = $('#GetUsersByTerm').val();
        $.ajax({
            type: 'GET',
            url: actionUrl,
            data: { term: value },
            success: function (data) {
                $('#users').html(data);
            }
        });
    }

    $(document).on('click', '.teamItem',function () {
        var teamId = $(this).children('.teamId').val();
        getUserTeamPos(teamId);
    });

    $('.userItem').click(function () {
        alert('ok');
    });
    $('#userTeamPos').droppable({
        drop: function (event, ui) {
            var userId = $(ui.draggable).children('.userId').val();
            var teamId = $('#selectedTeam').val();
            addUserToTeam(userId, teamId);
        }
    });
    /*Autocomplete Teams*/
    $("[data-autocomplete-source]#searchTeamInput").each(function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

    $('#searchTeamInput').keypress(function (e) {
        if (e.which === 13) {
            var value = $('#searchTeamInput').val();
            getTeamsByTerm(value);
            $("[data-autocomplete-source]#searchTeamInput").autocomplete('close');
            return false;
        }
    });
    /*Autocomplete Users*/
    $("[data-autocomplete-source]#searchUserInput").each(function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });

    $('#searchUserInput').keypress(function (e) {
        if (e.which === 13) {
            var value = $('#searchUserInput').val();
            getUsersByTerm(value);
            $("[data-autocomplete-source]#searchUserInput").autocomplete('close');
            return false;
        }
    });


    $(document).on('click','.teamEdit', function (e) {

        e.preventDefault();
        e.stopPropagation();
        $.get(this.href, function (data) {
            $('#dialogContent').html(data);
            $('#modDialog').modal('show');
        });
    });

    $(document).on('submit','#EditTeamForm', function(e) {
        e.preventDefault();

        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function(data) {
                if (data.Status === true) {
                    $('#modDialog').modal('toggle');
                    getTeamsByTerm($('#viewbagFilter').val(), $('#viewbagPage').val());
                } else {
                    $('#editTeamError').html(data.Message);
                }
            }
        });
    });

    //$(document).on('click', '#test', function (e) {

    //    e.preventDefault();
    //    alert('ok');
    //});

});

