@Code
    ViewData("Title") = "Home Page"
End Code

<div class="container-fluid" style="margin-top:9px;">
    <div class="row">
        <div class="col-sm-4">
            <label>Name</label>
            <input type="text" name="name" id="name" class="form-control" placeholder="Enter your name" />
        </div>

        <div class="col-sm-4">
            <label>number</label>
            <input type="text" name="number" maxlength="10" onkeypress="return event.charCode &gt;= 48 &amp;&amp; event.charCode &lt;= 57" id="number" class="form-control" placeholder="Enter your number" />
        </div>


        <div class="col-sm-4">
            <label>Address</label>
            <textarea class="form-control" id="address" placeholder="Enter your name"></textarea>
        </div>

    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Select district</label>
            <select id="district" class="form-control">
                <option id="select2">--Select district--</option>
                <option>Lucknow</option>
                <option>Sitapur</option>
                <option>Lakhimpur</option>
            </select>
        </div>
        <div class="col-sm-4">
            <label>Select State</label>
            <select id="state" class="form-control">
                <option id="select1">--Select district--</option>
                <option>Uttar Pradesh</option>
                <option>Delhi</option>
                <option>Tamilnadu</option>
            </select>
        </div>

        <div class="col-sm-4">
            <label>Select Country</label>
            <select id="country" class="form-control">
                <option id="select">--Select district--</option>
                <option id="">India</option>
                <option id="">Nepal</option>
                <option id="">Chaina</option>
            </select>
        </div>
    </div>

    <button id="btnSubmit" class="btn btn-success" style="margin-top:16px;">Submit</button>
    <button id="btnUpdate" class="btn btn-danger" style="margin-top:16px;">Update</button>


</div>
<table class="table table-striped">
    <thead>
        <tr>
            <th>Name</th>
            <th>Number</th>
            <th>Address</th>
            <th>District</th>
            <th>State</th>
            <th>Country</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody id="tbody">
    </tbody>

</table>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
<script>
    $(document).ready(function () {
        $('#btnSubmit').click(function () {
            var name = $('#name').val();
            if (name == '') {
                alert('name is Empty');
                $('#name').focus();
                return false;
            }
            var number = $('#number').val();
            if (number == '') {
                alert('Number Is Empty')
                $('#number').focus();
                return false;

            }
            var address = $('#address').val();
            if (address == '') {
                alert('address is empty');
                $('#address').focus();
                return false;

            }
            var address = $('#address').val();
            if (address == '') {
                $('#address').focus();
                return false;
            }
            var district = $('#district').val();
            if (district == '') {
                $('#district').focus();
                return false;
            }
            var state = $('#state').val();
            if (state == '') {
                alert('district is Empty');
                return false;

            }
            var country = $('#country').val();
            if (country == '') {
                alert('district is Empty');
                return false;

            }
            /* Number validation*/

            var row = $('<tr></tr>');
            var ceil1 = $('<td></td>').append($('#name').val());
            var ceil2 = $('<td></td>').append($('#number').val());
            var ceil3 = $('<td></td>').append($('#address').val());
            var ceil4 = $('<td></td>').append($('#district').val());
            var ceil5 = $('<td></td>').append($('#state').val());
            var ceil6 = $('<td></td>').append($('#country').val());
            var ceil8 = $('<td></td>').append('<button  class="btnEdit btn btn-success">Edit</button>');
            var ceil7 = $('<td></td>').append('<button  class="btnRemove btn btn-primary">Remove</button>');

            row.append(ceil1).append(ceil2).append(ceil3).append(ceil4).append(ceil5).append(ceil6).append(ceil7).append(ceil8);
            $('#tbody').append(row);

            $('input').val('');
            $('textarea').val('');
            $('#district').val('#select2');
            $('#state').val('');
            $('#country').val('');

            $('.btnRemove').bind('click', function () {
                $(this).closest('tr').remove();
            });

            $(".btnEdit").click(function (event) {
                var row = $(event.currentTarget).closest('tr');
                $('#name').val(row.find('td:eq(0)').text());
                $('#number').val(row.find('td:eq(1)').text());
                $('#address').val(row.find('td:eq(2)').text());
                $('#district').val(row.find('td:eq(3)').text());
                $('#state').val(row.find('td:eq(4)').text());
                $('#country').val(row.find('td:eq(5)').text());
                $('#name').focus();
                $('#btnUpdate').unbind().click(function () {
                    row.find('td:eq(0)').text($('#name').val());
                    row.find('td:eq(1)').text($('#number').val());
                    row.find('td:eq(2)').text($('#address').val());
                    row.find('td:eq(3)').text($('#district').val());
                    row = null;
                });
            });

        });


    });
</script>
