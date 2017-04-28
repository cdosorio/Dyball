import { Component } from '@angular/core';
import { SampleDataService } from './services/SampleData.service';

@Component({
    selector: 'my-about',
    templateUrl: '/partial/aboutComponent'
})

export class AboutComponent implements OnInit {
    testData: string[] = [];
    errorMessage: string;
    constructor(private sampleDataService: SampleDataService) { }
    ngOnInit() {
        this.sampleDataService.getSampleData()
            .subscribe((data: string[]) => this.testData = data,
            error => this.errorMessage = <any>error);
    }
}