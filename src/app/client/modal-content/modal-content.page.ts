import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
@Component({
  selector: 'app-modal-content',
  templateUrl: './modal-content.page.html',
  styleUrls: ['./modal-content.page.scss'],
})
export class ModalContentPage implements OnInit {

  constructor(private modalController: ModalController) { }

  dismiss() {
    this.modalController.dismiss();
  }
  
  ngOnInit() {
  }

}
