// wwwroot/js/app.js
document.addEventListener('DOMContentLoaded', function () {
    const menuToggle = document.querySelector('.menu-toggle');
    const sidebar = document.querySelector('.sidebar');

    if (menuToggle && sidebar) {
        menuToggle.addEventListener('click', function () {
            menuToggle.classList.toggle('active');
            sidebar.classList.toggle('active');
        });

        // Close sidebar when clicking outside on mobile
        document.addEventListener('click', function (e) {
            if (window.innerWidth <= 768) {
                if (!sidebar.contains(e.target) &&
                    !menuToggle.contains(e.target) &&
                    sidebar.classList.contains('active')) {
                    menuToggle.classList.remove('active');
                    sidebar.classList.remove('active');
                }
            }
        });
    }

    // Update current time in sidebar
    function updateTime() {
        const timeElement = document.querySelector('.current-time');
        if (timeElement) {
            const now = new Date();
            const timeString = now.toLocaleTimeString([], {
                hour: '2-digit',
                minute: '2-digit',
                hour12: true
            });
            timeElement.textContent = `🕒 ${timeString}`;
        }
    }

    updateTime();
    setInterval(updateTime, 60000);
});