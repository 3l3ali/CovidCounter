const searchForm = () => {
    let form = document.getElementById("search-form");
    form.addEventListener('submit', (e) => {
        e.preventDefault();
        let dest = document.getElementById("form-select").value;
        window.location.hash = "#"+ dest;
        let country = document.getElementById(dest).childNodes[1];
        country.classList.toggle("selected");
        setTimeout(()=>{country.classList.toggle("selected")},5000);
    });
};

export { searchForm };