import { Component, Inject, OnInit } from '@angular/core';
import { HomeService } from '../home/home.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public productslist: Products[];

  constructor(private router: Router, private homeService: HomeService) {
    this.homeService.listProducts().subscribe(result => {
      this.productslist = result["ProductList"];
    }, error => console.error(error));
  }
}

interface Products {
  ProductID: number;
  Name: string;
  Price: number;
  Stock: number;
  Image: string;
}
