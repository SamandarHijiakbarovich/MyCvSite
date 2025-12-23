// Progress bar animation
function animateProgressBar(progressBar, targetWidth, duration = 1200) {
    if (!progressBar) return;

    progressBar.style.transition = `width ${duration}ms cubic-bezier(0.34, 1.56, 0.64, 1)`;
    progressBar.style.width = `${targetWidth}%`;
}

// Intersection Observer for scroll animation
function setupSkillBarAnimation(dotNetHelper, progressBar, targetWidth) {
    const element = progressBar.parentElement.parentElement;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('animated');

                // Animate progress bar with delay
                setTimeout(() => {
                    animateProgressBar(progressBar, targetWidth);
                }, 300);

                observer.unobserve(entry.target);
            }
        });
    }, {
        threshold: 0.1,
        rootMargin: '50px'
    });

    observer.observe(element);
}