var accordion = document.getElementsByClassName('accordion');
var iterador; 

for (iterador = 0; iterador < accordion.length; iterador++) {
    accordion[iterador].addEventListener('click', function() {
        this.classList.toggle('active');

        var answerPanel = this.nextElementSibling;
        if(answerPanel.style.display === 'block') {
            answerPanel.style.display == 'none'
        } else {
            answerPanel.style.display == 'block'
        }
    })
}
