'use strict';
(function() {
  var countDown;
  var timeLoss;
  var mainScore;
  var flippedCards;
  var score = document.getElementsByClassName('score')[0];
  var timer = document.getElementsByClassName('timer')[0];
  var endGame = document.getElementsByClassName('game-over')[0];

  function Game() {
    var card = document.getElementsByClassName('card');
    var pics = ["url('images/1.jpg')", "url('images/2.jpg')", "url('images/3.jpg')", "url('images/4.jpg')", "url('images/5.jpg')", "url('images/1.jpg')", "url('images/2.jpg')", "url('images/3.jpg')", "url('images/4.jpg')", "url('images/5.jpg')"];

    timeLoss = 35;
    mainScore = 0;
    flippedCards = [];

    endGame.style.display = 'none';

    mix(pics);

    for (var i = 0; i < card.length; i++) {
      if(card[i].classList.contains('flipped')) {
        card[i].classList.toggle('flipped');
      }
      card[i].querySelector('.back').style.backgroundImage = pics[i];
      card[i].addEventListener('click', flip);
    }
    score.innerText = '00';

    startTimer();
  }

  function flip() {
    if (!this.classList.contains('flipped') && flippedCards.length < 2) {
      this.classList.toggle('flipped');

      flippedCards.push(this);

      if (flippedCards.length === 2) {
        checkMatch();
      }
    }
  }

  function checkMatch() {
    if (flippedCards[0].querySelector('.back').style.backgroundImage === flippedCards[1].querySelector('.back').style.backgroundImage) {
      flippedCards = [];
	
      score.innerText = '0' + ++mainScore;
    }
    else {
      setTimeout(flipBack, 1000);
    }
  }

  function flipBack() {
    flippedCards[0].classList.toggle('flipped');
    flippedCards[1].classList.toggle('flipped');

    flippedCards = [];
  }

  function startTimer() {
    timer.innerText = '0:35';
    countDown = setInterval(decrementTime, 1000);
  }

  function decrementTime() {
    if (timeLoss === 0) {
      timer.innerText = '0:0' + timeLoss;
      clearInterval(countDown);
      finalize();
    }
    if (timeLoss < 10) {
      timer.innerText = '0:0' + timeLoss;
    }
    if (timeLoss >= 10) {
      timer.innerText = '0:' + timeLoss;
    }
    if (mainScore === 5){
      clearInterval(countDown);
      finalize();
    }
    timeLoss--;
  }

  function finalize() {
    var restart = document.getElementsByTagName('button')[0];
    restart.addEventListener('click', Game);

    endGame.style.display = 'flex';

    if (mainScore === 5) {
      endGame.querySelector('h1').innerText = 'You won!';
    }
    else {
      endGame.querySelector('h1').innerText = 'You lost!';
    }
    endGame.querySelector('.final-score').innerText = 'Score: ' + mainScore;
    endGame.querySelector('.time').innerText = 'Time left: ' + timeLoss + ' sec.';
  }

  function mix(array) {
    for (var i = array.length - 1; i > 0; i--) {
      var j = Math.floor(Math.random() * (i + 1));
      var temp = array[i];
      array[i] = array[j];
      array[j] = temp;
    }
    return array;
  }

  Game();
})();
