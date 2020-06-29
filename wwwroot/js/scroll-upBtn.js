const scrollUp = () => {
    let upButton = document.getElementById("up-btn");

    // When the user scrolls down 20px from the top of the document, show the button
    window.addEventListener('scroll',() => {
        if (document.body.scrollTop > window.innerHeight || document.documentElement.scrollTop > window.innerHeight) {
            upButton.style.display = "block";
        } else {
            upButton.style.display = "none";
        }
    });

    upButton.addEventListener('click', () => {
        document.body.scrollTop = 0; // For Safari
        document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
    });
};

export { scrollUp };