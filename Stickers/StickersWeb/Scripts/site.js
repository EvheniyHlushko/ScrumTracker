$(document).ready(function () {

    $('#usersList li').css({ 'z-index': 100 }).draggable({
        'opacity': '0.5',
        'revert': true,
        'cursor': 'pointer'
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

    $('.teamItem').click(function () {
        var teamId = $(this).children('.teamId').val();
        getUserTeamPos(teamId);
    });

    $('#findUser').click(function () {
        getUsers();
    });


    $('#userTeamPos').droppable({
        drop: function (event, ui) {
            var userId = $(ui.draggable).children('.userId').val();
            var teamId = $('#selectedTeam').val();
            addUserToTeam(userId, teamId);
        }
    });

});