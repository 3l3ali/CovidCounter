import { scrollUp } from './scroll-upBtn.js';
import { searchForm } from './search-form.js';

$( window ).load(() => {
    $('.counter').counterUp({
        delay: 10,
        time: 1000
    });
});

window.addEventListener('load', () => {
    searchForm();
    scrollUp();
});