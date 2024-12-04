$(function () {
    // Fetch available time slots for selected course (populate #timeSlotSelect)
    $('#courseSelect').on('change', function () {
        var courseId = $(this).val();

        // Make AJAX request to fetch available slots based on courseId
        $.ajax({
            url: '/Booking/GetAvailableSlots?courseId=' + courseId,
            method: 'GET',
            success: function (data) {
                $('#timeSlotSelect').empty();
                $.each(data, function (index, slot) {
                    $('#timeSlotSelect').append('<option value="' + slot.time + '">' + slot.time + '</option>');
                });
            },
            error: function (error) {
                console.error('Error fetching slots: ', error);
            }
        });
    });

    // Handle form submission
    $('#bookForm').on('submit', function (event) {
        event.preventDefault();

        var golferName = $('#golferName').val();
        var courseId = $('#courseSelect').val();
        var selectedTime = $('#timeSlotSelect').val();

        // Make AJAX request to book the slot
        $.ajax({
            url: '/Booking/BookSlot',
            method: 'POST',
            data: { golferName: golferName, courseId: courseId, selectedTime: selectedTime },
            success: function (response) {
                alert(response); // Show success message
            },
            error: function (error) {
                alert('Error: ' + error.responseText); // Show error message
            }
        });
    });
});
