export function initAboutAnimations() {
    // 1. Scroll animatsiyalari (Intersection Observer)
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('active');

                // Agar bu skill bar bo'lsa, kengligini o'zgartiramiz
                if (entry.target.classList.contains('skill-progress')) {
                    entry.target.style.width = entry.target.dataset.width + '%';
                }

                // Agar bu raqam bo'lsa, sanaymiz
                if (entry.target.classList.contains('stat-number')) {
                    animateValue(entry.target);
                }
            }
        });
    }, { threshold: 0.1 });

    document.querySelectorAll('.animate-on-scroll, .skill-progress, .stat-number').forEach(el => {
        observer.observe(el);
    });
}

function animateValue(obj) {
    const start = 0;
    const end = parseInt(obj.dataset.count);
    const duration = 2000;
    let startTimestamp = null;
    const step = (timestamp) => {
        if (!startTimestamp) startTimestamp = timestamp;
        const progress = Math.min((timestamp - startTimestamp) / duration, 1);
        obj.innerHTML = Math.floor(progress * (end - start) + start);
        if (progress < 1) {
            window.requestAnimationFrame(step);
        }
    };
    window.requestAnimationFrame(step);
}